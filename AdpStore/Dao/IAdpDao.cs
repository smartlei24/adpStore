using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Dao
{
    public interface IAdpDao
    {
        List<Product> QueryProductByProductName(string productName);

        List<Product> QueryProductByProductStyle(string productType);
    }
}
