using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AdpStore.Models
{
    public class AdpStoreContext : DbContext
    {
        public AdpStoreContext (DbContextOptions<AdpStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
