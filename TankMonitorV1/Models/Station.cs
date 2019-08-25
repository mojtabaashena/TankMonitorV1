using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TankMonitorV1.Models
{
    public class Station
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="کد جایگاه را وارد نمایید")]
        [Display(Name = "کد جایگاه")]
        public int GSID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "نام را وارد نمایید")]
        [Display(Name = "نام جایگاه")]
        public string GSName { get; set; }

        [Display(Name = "آدرس")]
        public string Address { get; set; }

        [Display(Name = "موقعیت")]
        public string Location { get; set; }

        [Display(Name = "تعداد تانکرها")]
        public int TankCount { get; set; }

        [Display(Name = "سریال")]
        public string   SerialNumber { get; set; }

        [Display(Name = "اولویت نمایش")]
        public int Priority { get; set; }

        [Display(Name = "وضعیت")]
        public bool Enable { get; set; }

        [Display(Name = "توضیحات")]
        public string Descript { get; set; }

        public ICollection<Tank> Tanks { get; set; }
    }
}
