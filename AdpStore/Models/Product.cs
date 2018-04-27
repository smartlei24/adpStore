using System;
using System.Collections.Generic;
using System.Text;

namespace AdpStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string SimpleDescription { get; set; }

        public string DetailDescription { get; set; }

        public decimal Price { get; set; }

        public string ImageName { get; set; }

        public string Style { get; set; }

        public string Situation { get; set; }

        public DateTime Indate { get; set; }
    }
}
