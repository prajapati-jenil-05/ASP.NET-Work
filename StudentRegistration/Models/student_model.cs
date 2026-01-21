using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegistration.Models
{
    public class student_model
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter the name!")]
        public string Name { get; set; }
        public string City { get; set; }
    }
}