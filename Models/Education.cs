using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3_NilavarasuKumar.Models
{
    public class Education

    {

        [Key]
        public int Id { get; set; }
        [ForeignKey("CVModel")]
        public int CVModelId { get; set; }
        public virtual CVModel CVModel { get; set; }
        public string? Degree { get; set; }
        public string? InstitutionName { get; set; }
        public DateTime? GraduationDate { get; set; }

    }

}
