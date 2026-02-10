using System.ComponentModel.DataAnnotations;

namespace DEMOCORE_AB.Models
{
    public class Student
    {
        [Key]
        public int STUDENT_ID { get; set; }
        [Required(ErrorMessage = "Name Required!!!")]
        public required string STUDENT_NAME { get; set; }
        [Required(ErrorMessage = "Branch Required!!!")]
        public required string STUDENT_BRANCH { get; set; }
    }
}
