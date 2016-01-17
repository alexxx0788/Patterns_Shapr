using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.structure;

namespace Prototype
{
    /// <summary>
    /// Паттерн Прототип (Prototype) позволяет создавать объекты на основе уже ранее созданных объектов-прототипов.
    /// То есть по сути данный паттерн предлагает технику клонирования объектов.
    /// http://metanit.com/sharp/patterns/2.4.php
    /// 
    /// В данном случае имеем дело с интерфейсом IFigure с один методом Clone и двумя реализациями в виде Rectangle и Circle.
    /// Основное назначаение это создание копии обекта.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IFigure figure = new Rectangle(30, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(30);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
        }
    }
}
