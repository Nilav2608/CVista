using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment3CV_NilavarasuKumar.Data;
using Assignment3_NilavarasuKumar.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Assignment3_NilavarasuKumar.Services;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using DinkToPdf;

namespace Assignment3_NilavarasuKumar.Controllers
{
    public class CVModelsController : Controller
    {
        private readonly Assignment3CV_NilavarasuKumarContext _context;
        private readonly ICompositeViewEngine _viewEngine;
        //private readonly PdfService _pdfService;

        public CVModelsController(Assignment3CV_NilavarasuKumarContext context, ICompositeViewEngine viewEngine)
        {
            _context = context;
            //_pdfService = pdfService;
            _viewEngine = viewEngine;
        }

        // GET: CVModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.CVModel.ToListAsync());
        }

        // GET: CVModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {

                return NotFound();
            }

            var cVModel = await _context.CVModel
                .Include(a => a.WorkExperiences)
                .Include(a => a.EducationList)
                .Include(a => a.Skills)
                .Include(a => a.Languages)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cVModel == null)
            {
                return NotFound();
            }

            return View(cVModel);
        }

        // GET: CVModels/Create
        [HttpGet]
        public IActionResult Create()
        {
            CVModel model = new CVModel();
            model.EducationList.Add(new Education() { Id = 1 });
            model.WorkExperiences.Add(new WorkExperience() { Id = 1 });
            model.Languages.Add(new Language() { Id = 1 });
            model.Skills.Add(new Skill() { Id = 1 });
            return View(model);
            //var model = new CVModel   
            //{
            //    WorkExperiences = new List<WorkExperience> { new WorkExperience() },
            //    EducationList = new List<Education> { new Education() },
            //    Skills = new List<Skill> { new Skill() },
            //    Languages = new List<Language> { new Language() }
            //};
            //return View(model);
        }

        // POST: CVModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public async Task<IActionResult> Create(CVModel cVModel)
        {
         
                _context.CVModel.Add(cVModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }

        // GET: CVModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cVModel = await _context.CVModel
                .Include(a => a.WorkExperiences)
                .Include(a => a.EducationList)
                .Include(a => a.Skills)
                .Include(a => a.Languages)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cVModel == null)
            {
                return NotFound();
            }
            return View(cVModel);
        }

        // POST: CVModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ContactNumber,ProfessionalSummary,Email,Address")] CVModel cVModel)
        {
            if (id != cVModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cVModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CVModelExists(cVModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cVModel);
        }

        // GET: CVModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cVModel = await _context.CVModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cVModel == null)
            {
                return NotFound();
            }

            return View(cVModel);
        }

        // POST: CVModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cVModel = await _context.CVModel.FindAsync(id);
            if (cVModel != null)
            {
                _context.CVModel.Remove(cVModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        private bool CVModelExists(int id)
        {
            return _context.CVModel.Any(e => e.Id == id);
        }

        //Template Preview
        public async Task<IActionResult> TemplatePreview(string template, int? id)
        {

            // Fetch the CVModel using the provided id
            var cVModel = await _context.CVModel
                .Include(a => a.WorkExperiences)
                .Include(a => a.Skills)
                .Include(a => a.EducationList)
                .Include(a => a.Languages)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (cVModel == null)
            {
                return NotFound("\"CVModel with ID {id} not found..");
            }
            ViewBag.UseLayout = false;
            ViewData["Layout"] = null;
            // Render the appropriate template view
            if (template == "template1")
            {
                return View("ResumeTemplate", cVModel); // Pass the model to the view
            }
            else if (template == "template2")
            {
                return View("ResumeTemplate2", cVModel); // Pass the model to the second view
            }
            else
            {
                return BadRequest("Invalid template specified.");
            }
        }



        //Pdf Generation
        public IActionResult GeneratePdf(string template, int? id)
        {
            if (string.IsNullOrEmpty(template) || (template != "ResumeTemplate" && template != "ResumeTemplate2"))
            {
                return BadRequest("Invalid view.");
            }
            if (id == null)
            {
                return NotFound();
            }

            var cvModel =  _context.CVModel
                .Include(a => a.WorkExperiences)
                .Include(a => a.EducationList)
                .Include(a => a.Skills)
                .Include(a => a.Languages)
                .FirstOrDefault(m => m.Id == id);

            if (cvModel == null)
            {
                return NotFound();
            }
            ViewBag.UseLayout = false;
            //ViewData["Layout"] = null;

            //Extracts the string based on the selected HTML template
            var htmlContent = RenderViewToString(template, cvModel);

            // Use DinkToPdf to convert HTML to PDF
            var converter = new BasicConverter(new PdfTools());
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
            ColorMode = ColorMode.Color,
            Orientation = Orientation.Portrait,
            PaperSize = PaperKind.A4
        },
                Objects = {
            new ObjectSettings() {
                HtmlContent = htmlContent,
                WebSettings = { DefaultEncoding = "utf-8" },
                FooterSettings = { Center = "[page]" }
            }
        }
            };

            byte[] pdf = converter.Convert(doc);

            // Return the PDF file to the browser
            return File(pdf, "application/pdf", "CVista_" + cvModel.FullName + ".pdf");
        }


        //Renders the selected template view to string for pdf generation
        private  string RenderViewToString(string viewName, object model)
        {
            ViewData.Model = model;

            using var sw = new StringWriter();
            var viewResult = _viewEngine.FindView(ControllerContext, viewName, false);

            if (!viewResult.Success)
            {
                throw new InvalidOperationException($"View '{viewName}' not found.");
            }

            var viewContext = new ViewContext(
                ControllerContext,
                viewResult.View,
                ViewData,
                TempData,
                sw,
                new HtmlHelperOptions()
            );

             viewResult.View.RenderAsync(viewContext);
            return sw.ToString();
        }
    }
}
