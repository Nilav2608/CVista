using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Assignment3CV_NilavarasuKumar.Data;
using DinkToPdf;
using DinkToPdf.Contracts;
using Assignment3_NilavarasuKumar.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Assignment3CV_NilavarasuKumarContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Assignment3CV_NilavarasuKumarContext") ?? throw new InvalidOperationException("Connection string 'Assignment3CV_NilavarasuKumarContext' not found.")));



// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
