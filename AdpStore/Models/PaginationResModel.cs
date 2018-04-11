using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Models
{
    public class PaginationResModel
    {
        public int DataCount { get; set; }

        public List<Product> Products { get; set; }
    }
}
