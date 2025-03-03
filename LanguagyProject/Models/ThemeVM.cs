using System.ComponentModel.DataAnnotations;
namespace Languagy_project.Models
{
    public class ThemeVM
    {
        [Key]
        public int Id { get; set; }
        public string? ThemeTitle { get; set; }
        #region ThemeTitle
        public String Ar_ThemeTitle { get; set; }
        public String Fr_ThemeTitle { get; set; }
        public String ital_ThemeTitle { get; set; }
        public String Tur_ThemeTitle { get; set; }
        public String Ger_ThemeTitle { get; set; }
        public String Rom_ThemeTitle { get; set; }
        public String Esp_ThemeTitle { get; set; }
        public String Chines_ThemeTitle { get; set; }
        public String Filip_ThemeTitle { get; set; }
        #endregion
        public string? ThemeDescription { get; set; }
        #region ThemeDescription
        public String Ar_ThemeDescription { get; set; }
        public String Fr_ThemeDescription { get; set; }
        public String ital_ThemeDescription { get; set; }
        public String Tur_ThemeDescription { get; set; }
        public String Ger_ThemeDescription { get; set; }
        public String Rom_ThemeDescription { get; set; }
        public String Esp_ThemeDescription { get; set; }
        public String Chines_ThemeDescription { get; set; }
        public String Filip_ThemeDescription { get; set; }
        #endregion
        public string ThemeImgUrl { get; set; }
        public IFormFile ThemePhoto { get; set; }

    }
}
