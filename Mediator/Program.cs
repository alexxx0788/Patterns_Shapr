using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.structural;

namespace Mediator
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/3.9.php
    /// Паттерн Посредник (Mediator) представляет такой шаблон проектирования, который обеспечивает взаимодействие множества объектов без необходимости ссылаться друг на друга.
    /// Тем самым достигается слабосвязанность взаимодействующих объектов.
    /// 
    /// В примере показаны отношения между заказчиком программистом и тестером, все их общение происходит через посредника медиатора
    /// он имеет в себе 3 сущности, и каждая сущность из работников имеет в себе ссылку на медиатор.Так и производиться связь.
    /// После инициализации отдаем работу программисту, затем программист передает тестеру для тестирования и когда продукт протестирован 
    /// он уходит заказчику.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator mediator = new ManagerMediator();
            Colleague customer = new CustomerColleague(mediator);
            Colleague programmer = new ProgrammerColleague(mediator);
            Colleague tester = new TesterColleague(mediator);
            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Tester = tester;
            customer.Send("Есть заказ, надо сделать программу");
            programmer.Send("Программа готова, надо протестировать");
            tester.Send("Программа протестирована и готова к продаже");

            Console.Read();
        }
    }
}
