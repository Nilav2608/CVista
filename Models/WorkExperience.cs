using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3_NilavarasuKumar.Models
{
    public class WorkExperience
            
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CVModel")]
        public int CVModelId { get; set; }
        public virtual CVModel CVModel { get; set; }
        public string? JobTitle { get; set; }
        public string? CompanyName { get; set; }
        public string? JobDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
