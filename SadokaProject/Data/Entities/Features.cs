using System.ComponentModel.DataAnnotations;

namespace Languagy_project.Data.Entities
{
    public class Features
    {
        [Key]
        public int Id { get; set; }
        public String FeaturesDescription { get; set; }

        #region FeaturesDescription
       
        public String Ar_FeaturesDescription { get; set; }
        public String Fr_FeaturesDescription { get; set; }
        public String ital_FeaturesDescription { get; set; }
        public String Tur_FeaturesDescription { get; set; }
        public String Ger_FeaturesDescription { get; set; }
        public String Rom_FeaturesDescription { get; set; }
        public String Esp_FeaturesDescription { get; set; }
        public String Chines_FeaturesDescription { get; set; }
        public String Filip_FeaturesDescription { get; set; }
        #endregion

    }
}
