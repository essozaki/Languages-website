using System.ComponentModel.DataAnnotations;
namespace Languagy_project.Data.Entities
{
    public class Questions
    {
        [Key]
        public int Id { get; set; }
        public String Quest { get; set; }
        #region Question
        public String Ar_Quest { get; set; }
        public String Fr_Quest { get; set; }
        public String ital_Quest { get; set; }
        public String Tur_Quest { get; set; }
        public String Ger_Quest { get; set; }
        public String Rom_Quest { get; set; }
        public String Esp_Quest { get; set; }
        public String Chines_Quest { get; set; }
        public String Filip_Quest { get; set; }

        #endregion
        public String Answer { get; set; }
        #region Answer
        public String Ar_Answer { get; set; }
        public String Fr_Answer { get; set; }
        public String ital_Answer { get; set; }
        public String Tur_Answer { get; set; }
        public String Ger_Answer { get; set; }
        public String Rom_Answer { get; set; }
        public String Esp_Answer { get; set; }
        public String Chines_Answer { get; set; }
        public String Filip_Answer { get; set; }

        #endregion
    }
}
