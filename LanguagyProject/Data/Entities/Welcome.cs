using System.ComponentModel.DataAnnotations;
namespace Languagy_project.Data.Entities
{
    public class Welcome
    {
        [Key]
        public int Id { get; set; }
        public string WelcomeDescription { get; set; }
        #region WelcomeDescription
        public String Ar_WelcomeDescription { get; set; }
        public String Fr_WelcomeDescription { get; set; }
        public String ital_WelcomeDescription { get; set; }
        public String Tur_WelcomeDescription { get; set; }
        public String Ger_WelcomeDescription { get; set; }
        public String Rom_WelcomeDescription { get; set; }
        public String Esp_WelcomeDescription { get; set; }
        public String Chines_WelcomeDescription { get; set; }
        public String Filip_WelcomeDescription { get; set; }
        #endregion
        public string WelcomeIImgUrl { get; set; }

    }
}
