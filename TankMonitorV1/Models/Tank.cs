using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TankMonitorV1.Models
{
    public class Tank
    {
        public int Id { get; set; }

        
       

        [Display(Name = "شماره")]
        public int TankNumber { get; set; }

        [Display(Name = "سریال")]
        public int SerialNumber { get; set; }

        [Display(Name = "ظرفیت")]
        public int Capasity { get; set; }

        [Display(Name = "نوع سوخت")]
        public int FuelType { get; set; }

        [Display(Name = "اولویت نمایش")]
        public int Priority { get; set; }

        [Display(Name = "وضعیت")]
        public bool Enable { get; set; }

        [Display(Name = "توضیحات")]
        public string Descript { get; set; }

        [Display(Name = "کد جایگاه")]
        public int GSID { get; set; }
        public Station Station { get; set; }

    }
}
