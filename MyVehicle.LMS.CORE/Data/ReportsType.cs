using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class ReportsType
    {
        [Key]
        public int ReportType { get; set; }
        public string ReportTypeName { get; set; }
    }
}
