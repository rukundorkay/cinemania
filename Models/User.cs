using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;

namespace CineMania.Models
{
    public class User
    {
        public int  Id { get; set; }
        [Required]
        [MinLength(3,ErrorMessage = "Name must contain at least 3 characters")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required] 
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        
    }

    
}