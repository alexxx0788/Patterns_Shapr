using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visitor.structure;

namespace Visitor
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/3.11.php
    /// Паттерн Посетитель (Visitor) позволяет определить операцию для объектов других классов без изменения этих классов.
    /// В данном примете речь пойдет о наборе разных классов над которым нужно выполнить одну операцию.
    /// Есть банк у которого есть клиенты люди и компании, оби эти сущности реализуют интерфейс IAccount и метод Accept.
    /// Добавляет эти сущности в нашу стркутуру Bank.
    /// Затем реализуем паттерн Visitor, для конвертации сущностей в html и xml.
    /// У банка вызываем метод Accept что будет конвертировать все сущности структуры в один формат. 
    /// Мы проходим по списку сущностей и вызываем метод Accept, что в последствии выызывает метод Accept сущности а та в свою очередь метод для конвертации в определенный формат
    /// VisitCompanyAc или VisitPersonAcc
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var structure = new Bank();
            structure.Add(new Person { Name = "Иван Алексеев", Number = "82184931" });
            structure.Add(new Company { Name = "Microsoft", RegNumber = "ewuir32141324", Number = "3424131445" });
            structure.Accept(new HtmlVisitor());
            structure.Accept(new XmlVisitor());

            Console.Read();
        }
    }
}
