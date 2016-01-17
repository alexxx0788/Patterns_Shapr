using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.structure
{
    abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string n)
        {
            Name = n;
        }
        // фабричный метод
        abstract public House Create();
    }
}
