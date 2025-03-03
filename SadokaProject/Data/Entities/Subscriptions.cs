using System.ComponentModel.DataAnnotations;

namespace Languagy_project.Data.Entities
{
    public class Subscriptions
    {
        [Key]
        public int Id { get; set; }
        public String Email { get; set; }
    }
}
