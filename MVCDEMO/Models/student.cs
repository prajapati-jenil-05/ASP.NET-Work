using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDEMO.Models
{
    public class student
    {
        [Key]
        [Required]
        public int studentid { get; set; }
        [Required(ErrorMessage = "Enter the name!")]
        public string studentname { get; set; } 
        public int studentcity { get; set; }
    }
}