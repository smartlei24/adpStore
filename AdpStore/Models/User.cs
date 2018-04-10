using System;
using System.Collections.Generic;
using System.Text;

namespace AdpStore.Models
{
    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }

        public DateTime Indate { get; set; }
    }
}
