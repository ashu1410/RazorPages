using System.ComponentModel.DataAnnotations;

namespace Razor.Models


{
    public class resPage
    {
        [Key]
        public int ID_res { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string Title { get; set; }
        [RegularExpression(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")]
        [Required]
        public string Link { get; set; }
        public string Img_path { get; set; }
        [Required]
        public ResCategory? resCat { get; set; }
    
        public resPage()
        {
            this.Img_path = "~/resources/" + Img_path;
        }
    }
}
