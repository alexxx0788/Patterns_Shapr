using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.structure;

namespace Builder
{
    /// <summary>
    /// Строитель (Builder) - шаблон проектирования, который инкапсулирует создание объекта и позволяет разделить его на различные этапы.
    /// http://metanit.com/sharp/patterns/2.5.php
    /// 
    /// Пример на основе пекарни.
    /// Учасники Baker - который отвечает за выпечку и у него есть одно умение Bake, у него всредине есть налаженный процес что за чем делать.
    /// На вход он принимает параметр BreadBuilder. Это абстрактный класс что инкапсулирует в себя процесс выпикание хлеба и в себе же он содержит сам объект хлеба.
    /// Одно из конкретных реализаций BreadBuilder это WheatBreadBuilder, который умеет выпекать пшеничный хлеб где по своему реализованы все методы BreadBuilder-а.
    /// В программе мы создали пекаря, передали ему на вход конкретную реализацию выпекания пшеничного хлеба WheatBreadBuilder и сказали что-бы он выпекал .Bake.
    /// В результате получиться хлеб.  
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // содаем объект пекаря
            Baker baker = new Baker();
            // создаем билдер для ржаного хлеба
            BreadBuilder builder = new RyeBreadBuilder();
            // выпекаем
            baker.Bake(builder);
            Bread ryeBread = builder.Bread;
            Console.WriteLine(ryeBread.ToString());
            // cоздаем билдер для пшеничного хлеба
            builder = new WheatBreadBuilder();
            baker.Bake(builder);
            Bread wheatBread = builder.Bread;
            Console.WriteLine(wheatBread.ToString());

            Console.Read();
        }
    }
}
