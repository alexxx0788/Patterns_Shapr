using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.structure;

namespace Abstract_Factory
{
    /// <summary>
    /// Паттерн "Абстрактная фабрика" (Abstract Factory) предоставляет интерфейс для создания семейств взаимосвязанных объектов
    /// с определенными интерфейсами без указания конкретных типов данных объектов.
    /// 
    /// http://metanit.com/sharp/patterns/2.2.php
    /// В этом паттерне главный учстник это фабрика которая умеет делать кондитерские изделия Cake,Profitrole,Muffin.
    /// Он изолирует конкретные классы по этому умеет возможность заменять семейство продуктов.
    /// По этому здесь есть абстрактная фабрика что умеет делать 3 абстрактных продукта.
    /// Городская кондитерская наследует функционал фабрики и может выпускать не абстрактные продукты а уже реальные :
    /// Пражский торт, Шоколадный профитроль, Французкий Мафин.
    /// </summary>
    class Program
    {
        static void Main()
        {
            //creating an instance of a confectionery shop     
            var confectionery = new CityCenterConfectionery();
            //order sweets from the city center confectionery shop
            Console.WriteLine(confectionery.MakeCake().Name);
            confectionery.MakeMuffins(7).ForEach((m) => Console.WriteLine(m.Name));
            confectionery.MakeProfiteroles(5).ForEach((p) => Console.WriteLine(p.Name));
            Console.Read();
        }
    }
}
