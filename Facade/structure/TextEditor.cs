using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.structure
{
    // текстовый редактор
    class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Написание кода");
        }
        public void Save()
        {
            Console.WriteLine("Сохранение кода");
        }
    }
}
