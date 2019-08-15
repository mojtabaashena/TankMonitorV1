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

        [Required(AllowEmptyStrings =false,ErrorMessage ="code jaygah")]
        [Display(Name = "code jaygah")]
        public int GSID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "code jaygah")]
        [Display(Name = "code jaygah")]
        public string GSName { get; set; }

        public string Address { get; set; }

        public string Location { get; set; }


    }
}
