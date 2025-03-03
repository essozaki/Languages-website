using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Languagy_project.Models
{
    public class ContactUSVM
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Message { get; set; } 

        [AllowNull]
        public string? Phone { get; set; }
        [AllowNull]
        public string? Address { get; set; }
    }

}
