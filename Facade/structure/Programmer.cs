using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.structure
{
    class Programmer
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
