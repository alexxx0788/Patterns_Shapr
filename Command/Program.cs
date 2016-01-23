using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Command.structure;

namespace Command
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/3.3.php
    /// Паттерн "Команда" (Command) позволяет инкапсулировать запрос на выполнение определенного действия в виде отдельного объекта.
    /// Этот объект запроса на действие и называется командой.
    /// При этом объекты, инициирующие запросы на выполнение действия, отделяются от объектов, которые выполняют это действие.
    /// 
    /// Для примера можно взять ситуацию для включения и  выключения прибора, к примеру телевизор.
    /// В центре внимания рассматриваеться интерфейс ICommand c двумя методами Execute и Undo. В качестве реализации этого интерфейса есть класс TVOnCommand который реализует методы. Он может включать и выключать сущность TV.
    /// Класс TV это сущность над которой будут производиться действие, она имеет методы On и Off которые в результате будут вызываться в TVOnCommand.
    /// Также есть в программе сущность Pult который имеет поле ICommand который будет принимать его через комманду SetCommand и производить действия над сущностью TV. Pult->TVOnCommand->TV.
    /// После всей этой установки мы можем пользоваться методами  pult.PressButton() и pult.PressUndo().
    /// Мы можем легко подменить TV на Microwave и создать MVOnCommand и пользоваться этим паттерном.
    ///  </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            TV tv = new TV();
            pult.SetCommand(new TVOnCommand(tv));
            pult.PressButton();
            pult.PressUndo();

            Console.Read();
        }
    }
}
