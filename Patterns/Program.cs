using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.structure;

namespace Patterns
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/3.1.php
    /// Паттерн Стратегия (Strategy) представляет шаблон проектирования, 
    /// который определяет набор алгоритмов, инкапсулирует каждый из них и обеспечивает их взаимозаменяемость. 
    /// В зависимости от ситуации мы можем легко заменить один используемый алгоритм другим.
    /// При этом замена алгоритма происходит независимо от объекта, который использует данный алгоритм.
    /// 
    ///В данном случае для для примера взяты автомобили которые могут передвигаться на електричестве и на бензине.
    /// Испорльзуя dependency injection мы можем изменить тип енегрии для использования.
    /// Главный класс это Car, IMovable интерфейс имеет один метод Move, поле такого типа содержиться в классе Car.
    /// Есть две реализации IMovable, PetrolMove и ElectricMove. Во время выполнения программы есть возможность переопредедлить тип енергии для использования.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car(4, "Volvo", new PetrolMove());
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();

            Console.ReadLine();
        }
    }
}
