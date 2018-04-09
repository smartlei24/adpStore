using System;
using System.Collections.Generic;
using System.Text;

namespace AdpStoreEntity
{
    public class ShoppingCart
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int UserId { get; set; }

        public DateTime InDate { get; set; }
    }
}
