using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using State.structure;

namespace State
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/3.6.php
    /// Состояние (State) - шаблон проектирования, который позволяет объекту изменять свое поведение в зависимости от внутреннего состояния.
    /// 
    /// В данном примере паттерн State можно обяснить на примере состояний воды : твёрдый, жидкий, газообразный.
    /// Главный участник  IWaterState c двумя методами (2 операции которые применимы к каждому из состояний).
    /// 3 наследника GasWaterState,LiquidWaterState,SolidWaterState.
    /// Ну и сущность вода состояния для которых мы и реализовываем также он содержит поле типа IWaterState.
    /// </summary>
    class Program
    {
        private static void Main(string[] args)
        {
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();

            Console.Read();
        }


    }
}
