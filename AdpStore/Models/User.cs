﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AdpStore.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "用户名不能为空")]
        public string Name { get; set; }

        [Required(ErrorMessage = "密码不能为空")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Address { get; set; }

        public string EmailAddress { get; set; }

        public decimal Balance { get; set; }

        public string TelNumber { get; set; }

        public DateTime Indate { get; set; }
    }
}
