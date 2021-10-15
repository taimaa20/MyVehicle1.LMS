﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
 public   class Users
    {
        [Key]
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UserImage { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public int SettingId { get; set; }
        [ForeignKey("RoleId")]

        public virtual Role Role { get; set; }

        [ForeignKey("SettingId")]

        public virtual WebsiteSetting WebsiteSetting { get; set; }

    }
}
