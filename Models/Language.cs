using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3_NilavarasuKumar.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CVModel")]
        public int CVModelId { get; set; }
        public virtual CVModel CVModel { get; set; }
        public string? LanguageName { get; set; }
        public string? ProficiencyLevel { get; set; }
    }
}
