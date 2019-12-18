using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TankMonitorV1.Models
{
    public class HRM_Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "کد ملی را وارد نمایید")]
        [Display(Name = "کد ملی")]
        public string NationalCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "نام را وارد نمایید")]
        [Display(Name = "نام")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "نام خانوادگی را وارد نمایید")]
        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }

        [Display(Name = "نام پدر")]
        public string FatherName { get; set; }

        [Display(Name = "وضعیت تاهل")]
        public int MaritalStatus { get; set; }

        [Display(Name = "تعداد فرزند")]
        public int NumberOfChild { get; set; }

        [Display(Name = "جنسیت")]
        public int Sex { get; set; }

        [Display(Name = "تحصیلات")]
        public int EducationCode { get; set; }

        [Display(Name = "محل خدمت")]
        public int PlaceOfWork { get; set; }

        [Display(Name = "شماره شناسنامه")]
        public string IdentityNumber { get; set; }

        [Display(Name = "محل صدور")]
        public string IdentityPlaceOfIssuance { get; set; }

        [Display(Name = "بسیجی")]
        public int BasijType { get; set; }

        [Display(Name = "وضعیت")]
        public bool Enable { get; set; }

        [Display(Name = "توضیحات")]
        public string Descript { get; set; }

    }
}
