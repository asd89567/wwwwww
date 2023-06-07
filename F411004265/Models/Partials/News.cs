using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F411004265.Models
{
    [MetadataType(typeof(NewsMetadata))]
    public partial class News
    {
    }
  
    public class NewsMetadata
    {
        public int Id
        {
            get; set;
        }
        [Required(ErrorMessage = "欄位標題必須要為最大長度為50的字串")]
        [Display(Name = "標題")]
        [StringLength(50)]
        

        public string Title
        {
            get; set;
        }
        [Required(ErrorMessage = "不能為空")]
        [Display(Name = "內容")]
        public string Content
        {
            get; set;
        }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "publsh")]
        public Nullable<System.DateTime> PublishDate
        {
            get; set;
        }
    }

}