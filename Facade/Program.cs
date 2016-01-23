using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facade.structure;

namespace Facade
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/4.3.php
    /// Фасад (Facade) представляет шаблон проектирования, который позволяет скрыть сложность системы с помощью предоставления упрощенного интерфейса для взаимодействия с ней.
    /// 
    /// В качестве примера учавствует среда разработки Visual Studio IDE, она являеться фасадом для таких компонентов как текстовый редактор, компилятор и среда CLR.
    /// У каждого из компонентов есть свои методы.
    /// Используя фасад от IDE, мы можем собрать воедино все компоненты и определить свои методы что внутри будут иметь вызовы методов каждого из компонентов, то есть их комбинаций.
    /// Также у нас есть программист что используя IDE может создать приложения.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);

            Console.Read();
        }
    }
}
