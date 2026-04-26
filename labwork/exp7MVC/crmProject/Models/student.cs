using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crmProject.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name Field Required")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Email Field Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Format")] // Optional: Ensures it's a real email
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Age Field Required")]
        [Range(1, 120, ErrorMessage = "Please enter a valid age")] // Recommended: Ensures age is a number
        public string Age { get; set; } = "";

        [Required(ErrorMessage = "Password Field Required")]
        [DataType(DataType.Password)] // Useful: Tells the UI to hide characters
        public string Password { get; set; } = "";
        
    }
}