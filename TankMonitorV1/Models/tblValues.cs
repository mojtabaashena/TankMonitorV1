using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TankMonitorV1.Models
{
    public class tblValues
    {
        public int Id { get; set; }

        [Display(Name = "پدر")]
        public int fldValParent { get; set; }

        [Display(Name = "اولویت نمایش")]
        public int fldValCode { get; set; }

        [Display(Name = "نام")]
        public string fldValName { get; set; }

        [Display(Name = "مقدار")]
        public string fldValData { get; set; }

        [Display(Name = "توضیحات")]
        public string fldValDescrip { get; set; }

        [Display(Name = "وضعیت")]
        public bool fldValEnable { get; set; }
    }
}
