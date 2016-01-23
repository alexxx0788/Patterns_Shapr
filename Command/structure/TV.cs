using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.structure
{
    class TV
    {
        public void On()
        {
            Console.WriteLine("Телевизор включен!");
        }

        public void Off()
        {
            Console.WriteLine("Телевизор выключен...");
        }
    }
}
