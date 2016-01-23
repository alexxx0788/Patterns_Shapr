using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Proxy.structure
{
    class PageContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }
}
