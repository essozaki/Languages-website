using System.ComponentModel.DataAnnotations;
namespace Languagy_project.Data.Entities
{
    public class Partners
    {
        [Key]
        public int Id { get; set; }
        //public string PartnersName { get; set; }
        public string PartnersLogoUrl { get; set; }
    }
}
