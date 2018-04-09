using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdpStoreEntity
{
    public class Order
    {
        public int OrderId { get; set;}
        public int UserId { get; set;}
        public int ProductId { get; set;}
        public int Quantity { get; set;}
        public string OrderPrice { get; set;}
        public DateTime Indate { get; set;}
    }
}