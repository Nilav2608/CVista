using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3_NilavarasuKumar.Models
{
    public class Skill
    {
        public int Id { get; set; }

        [ForeignKey("CVModel")]
        public int CVModelId { get; set; }
        public virtual CVModel CVModel { get; set; }
        public string? SkillName { get; set; }
    }
}
