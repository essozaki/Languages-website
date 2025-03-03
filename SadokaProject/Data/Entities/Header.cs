using System.ComponentModel.DataAnnotations;

namespace Languagy_project.Data.Entities
{
    public class Header
    {
        [Key]
        public int Id { get; set; }


        #region title
        public string HeaderTitle { get; set; }

        public String Ar_HeaderTitle { get; set; }
        public String Fr_HeaderTitle { get; set; }
        public String ital_HeaderTitle { get; set; }
        public String Tur_HeaderTitle { get; set; }
        public String Ger_HeaderTitle { get; set; }
        public String Rom_HeaderTitle { get; set; }
        public String Esp_HeaderTitle { get; set; }
        public String Chines_HeaderTitle { get; set; }
        public String Filip_HeaderTitle { get; set; }
        #endregion
        #region HeaderDescription
        public string HeaderDescription { get; set; }

        public String Ar_HeaderDescription { get; set; }
        public String Fr_HeaderDescription { get; set; }
        public String ital_HeaderDescription { get; set; }
        public String Tur_HeaderDescription { get; set; }
        public String Ger_HeaderDescription { get; set; }
        public String Rom_HeaderDescription { get; set; }
        public String Esp_HeaderDescription { get; set; }
        public String Chines_HeaderDescription { get; set; }
        public String Filip_HeaderDescription { get; set; }
        #endregion
        public string HeaderImgUrl { get; set; }

    }
}
