# CVista

This project is a **CVista** web application built using **ASP.NET Core 8**, where users can input their personal information, work experience, skills, education, and more, to generate professional resumes. The resumes are dynamically generated and formatted into a user-friendly PDF document.

## Features

- **Personal Information Section**: Display user's full name, email, contact number, and location.
- **Professional Summary Section**: Allows users to add a brief introduction or professional summary.
- **Work Experience Section**: Users can input their work experience with company names, job titles, employment dates, and job descriptions.
- **Skills Section**: Users can list their skills, displayed in a neat and organized manner.
- **Education Section**: Users can input their educational qualifications including the institution, degree, and graduation year.
- **Languages Section**: Users can list languages they know.
- **Responsive Layout**: The layout is responsive for different screen sizes, ensuring a good experience on desktops, tablets, and mobile devices.
- **PDF Generation**: The resume can be downloaded as a PDF document with all the sections formatted properly.
  
## Technologies Used

- **ASP.NET Core 8** for building the backend and rendering the web pages.
- **HTML5 & CSS3** for structuring and styling the web pages.
- **Razor Pages** for dynamic content rendering and template generation.
- **JavaScript** for any client-side functionality (if required).
- **Bootstrap** (or custom CSS) for responsive and modern design.
- **PDFSharp** for generating PDF resumes.

## Installation
--**Install .NET 8
--**dotnet entity framework core tools - 8.0.11
--**dotnet entity framework core sqlserver - 8.0.11

## Pdf package
--**Install DinkToPdf -v1.0.8
--**Note- If your are getting an error with DinkToPdf while generating the pdf, similar like "DinkToPdf dll not found libwkhtmltox" Run this command `Install-Package DinkToPdfCopyDependencies -Version 1.0.8` in your nuget package manager console


### Prerequisites

Before getting started, ensure you have the following installed:

- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- [ASP.NET Core SDK 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server (Optional)] for storing resume data, or you can use in-memory database.
