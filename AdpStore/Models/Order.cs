using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdpStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal OrderPrice { get; set; }
        public string ImageName { get; set; }
        public DateTime Indate { get; set; }
    }
}
