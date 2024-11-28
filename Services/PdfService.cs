using DinkToPdf;
using DinkToPdf.Contracts;

namespace Assignment3_NilavarasuKumar.Services

{
    
    public class PdfService
    {
        private readonly IConverter _converter;

        public PdfService(IConverter converter)
        {
            _converter = converter;
        }

        public byte[] GeneratePdf(string htmlContent)
        {
            var pdfDoc = new HtmlToPdfDocument
            {
                GlobalSettings = new GlobalSettings
                {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.A4,
                    Margins = new MarginSettings { Top = 10, Bottom = 10, Left = 10, Right = 10 }
                },
                Objects = { new ObjectSettings { HtmlContent = htmlContent } }
            };

            return _converter.Convert(pdfDoc);
        }
    }
}
