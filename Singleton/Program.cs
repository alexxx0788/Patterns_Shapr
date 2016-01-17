using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton.structure;

namespace Singleton
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/2.3.php
    /// Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует, 
    /// что для определенного класса будет создан только один объект, а также предоставит к этому объекту точку доступа.
    /// Во время запуска компьютера у нас может быть только одна операционаая система если попытаться запустить другу одновременно но этого сделать не удасться.
    /// Отличие от глобальной переменной в том что если не нужно синглтон создавать не будут.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);

            // у нас не получится изменить ОС, так как объект уже создан    
            comp.OS = OS.getInstance("Windows 10");
            Console.WriteLine(comp.OS.Name);

            Console.ReadLine();
        }
    }   
}
