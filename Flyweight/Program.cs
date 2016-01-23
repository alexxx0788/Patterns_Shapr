using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flyweight.structure;

namespace Flyweight
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/4.7.php
    /// Паттерн Приспособленец (Flyweight) - структурный шаблон проектирования, который позволяет использовать разделяемые объекты сразу в нескольких контекстах.
    /// Данный паттерн используется преимущественно для оптимизации работы с памятью.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double longitude = 37.61;
            double latitude = 55.74;

            HouseFactory houseFactory = new HouseFactory();
            for (int i = 0; i < 5; i++)
            {
                House panelHouse = houseFactory.GetHouse("Panel");
                if (panelHouse != null)
                    panelHouse.Build(longitude, latitude);
                longitude += 0.1;
                latitude += 0.1;
            }

            for (int i = 0; i < 5; i++)
            {
                House brickHouse = houseFactory.GetHouse("Brick");
                if (brickHouse != null)
                    brickHouse.Build(longitude, latitude);
                longitude += 0.1;
                latitude += 0.1;
            }

            Console.Read();
        }
    }
}
