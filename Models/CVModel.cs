using System.ComponentModel.DataAnnotations;
namespace Assignment3_NilavarasuKumar.Models
{
    public class CVModel
    {
        
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FullName { get; set; } = "";

        [Required]
        [Phone]
        public string? ContactNumber { get; set; } = "";
        [Required]
        public string? ProfessionalSummary { get; set; } = "";

        [Required]
        [EmailAddress]
        public string? Email { get; set; } = "";

        public string? Address { get; set; } = "";
        public virtual List<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
        public virtual List<Education> EducationList { get; set; } = new List<Education>();
        public virtual List<Skill> Skills { get; set; } = new List<Skill>();
        public virtual List<Language> Languages { get; set; } = new List<Language>();
        
    }
}
