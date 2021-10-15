using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class Notifications
    {
        [Key]
        public int NotificationId { get; set; }
        public DateTime NotificationDate { get; set; }
        public int NotificationStatus { get; set; }
        public string NotificationText { get; set; }

        [ForeignKey("UserId")]

        public virtual Users Users { get; set; }
    }
}
