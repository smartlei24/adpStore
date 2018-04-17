using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Models
{
    public class QueryProductResult
    {
        public int DataCount;

        public List<Product> Data;

        public string RedirectUrl;
    }
}
