using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memento.structure;

namespace Memento
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/3.10.php
    /// Паттерн Хранитель (Memento) позволяет выносить внутреннее состояние объекта за его пределы для последующего возможного
    /// восстановления объекта без нарушения принципа инкапсуляции.
    /// 
    /// Для примера взят случай из игры где нужно сохранять состояние и затем иметь возможность востанввливаться.
    /// Есть герой где он можетсохранить свое состояние возвращая объект HeroMemento что имеет в себе поля которые он хочет сохранить,
    /// затем есть объект истории игры где храниться стек объектов HeroMemento, и также герой используя стек из истории может востановить свое
    /// состояние.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Shout(); // делаем выстрел, осталось 9 патронов
            GameHistory game = new GameHistory();

            game.History.Push(hero.SaveState()); // сохраняем игру

            hero.Shout(); //делаем выстрел, осталось 8 патронов

            hero.RestoreState(game.History.Pop());

            hero.Shout(); //делаем выстрел, осталось 8 патронов

            Console.Read();
        }
    }
}
