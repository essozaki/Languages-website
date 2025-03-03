using System.ComponentModel.DataAnnotations;
namespace Languagy_project.Models
{
    public class MembersVM
    {
        [Key]
        public int Id { get; set; }
        public string MemberName { get; set; }
        #region Name
        public String Ar_MemberName { get; set; }
        public String Fr_MemberName { get; set; }
        public String ital_MemberName { get; set; }
        public String Tur_MemberName { get; set; }
        public String Ger_MemberName { get; set; }
        public String Rom_MemberName { get; set; }
        public String Esp_MemberName { get; set; }
        public String Chines_MemberName { get; set; }
        public String Filip_MemberName { get; set; }

        #endregion

        public String MemberTitle { get; set; }
        #region Title
        public String Ar_MemberTitle { get; set; }
        public String Fr_MemberTitle { get; set; }
        public String ital_MemberTitle { get; set; }
        public String Tur_MemberTitle { get; set; }
        public String Ger_MemberTitle { get; set; }
        public String Rom_MemberTitle { get; set; }
        public String Esp_MemberTitle { get; set; }
        public String Chines_MemberTitle { get; set; }
        public String Filip_MemberTitle { get; set; }

        #endregion
        public String MemberImgUrl { get; set; }
        public IFormFile MemberPhoto { get; set; }
    }
}
