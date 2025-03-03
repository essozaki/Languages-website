using System.ComponentModel.DataAnnotations;
namespace Languagy_project.Models
{
    public class PartnersVM
    {
        [Key]
        public int Id { get; set; }
        public string PartnersLogoUrl { get; set; }
        public IFormFile PartnersPhoto { get; set; }

    }
}
