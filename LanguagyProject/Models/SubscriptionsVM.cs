using System.ComponentModel.DataAnnotations;
namespace Languagy_project.Models
{
    public class SubscriptionsVM
    {
        [Key]
        public int Id { get; set; }
        public String Email { get; set; }

    }
}
