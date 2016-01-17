using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Method.structure;


namespace Factory_Method
{
    /// <summary>
    /// Фабричный метод (Factory Method) - это паттерн, который определяет интерфейс для создания объектов некоторого класса,
    /// но непосредственное решение о том, объект какого класса создавать происходит в подклассах. То есть паттерн предполагает,
    /// что базовый класс делегирует создание объектов классам-наследникам.
    /// 
    /// http://metanit.com/sharp/patterns/2.1.php
    /// Случай когда есть абстрактный застройщик который умеет только стоить
    /// и несколько реальных (один стоит дома из дерева другой панельные дома)
    /// Также есть абстрактная сущность дом, в даном случае есть деревяные и панельные дома.
    /// В случае желания расширить нужно добавить нового застройщика и новый тип домов - н.п. кирпичный.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            House house1 = dev.Create();

            dev = new WoodDeveloper("Частный застройщик");
            House house2 = dev.Create();

            Console.ReadLine();
        }
    }
}
