using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.structure;

namespace Decorator
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/4.1.php
    /// Декоратор (Decorator) представляет структурный шаблон проектирования, который позволяет динамически подключать к объекту дополнительную функциональность.
    /// Для примера взята пицерия которая может печь разные типы пицци в зависемости от комбинации добавок, от комбинаций будет зависеть и цена пицци.
    /// Абстрактный класс Pizza и наследники ItalianPizza,BulgerianPizza.
    /// Абстрактный класс PizzaDecorator и наследники CheesePizza,TomatoPizza. 
    /// Декоратор предназначен для динамического добавления объекту новой функциональности. Является гибкой альтернативой механизму наследования, в том числе и множественного.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1); // итальянская пицца с томатами
            Console.WriteLine("Название: {0}", pizza1.Name);
            Console.WriteLine("Цена: {0}", pizza1.GetCost());

            Pizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2);// итальянская пиццы с сыром
            Console.WriteLine("Название: {0}", pizza2.Name);
            Console.WriteLine("Цена: {0}", pizza2.GetCost());

            Pizza pizza3 = new BulgerianPizza();
            pizza3 = new TomatoPizza(pizza3);
            pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
            Console.WriteLine("Название: {0}", pizza3.Name);
            Console.WriteLine("Цена: {0}", pizza3.GetCost());

            Console.ReadLine();
        }
    }
}
