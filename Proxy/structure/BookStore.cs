using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy.structure
{
    class BookStore
    {
        PageContext db;
        public BookStore()
        {
            db = new PageContext();
        }
        public Page GetPage(int number)
        {
            return db.Pages.FirstOrDefault(p => p.Number == number);
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
