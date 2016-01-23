using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template_Method.structure;

namespace Template_Method
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/3.4.php
    /// Шаблонный метод (Template Method) определяет общий алгоритм поведения подклассов, позволяя им переопределить отдельные шаги этого алгоритма без изменения его структуры. Когда использовать шаблонный метод?
    /// 
    /// В данном случае речь идет об одном алгоритме где выполняеться набор одних действий, из который действия могут быть переопределены или быть вовсе без имплементации.
    /// У нас есть школа и универ где люди выполняют один алгоритм обучение.
    /// Но обучение отличается в обоих заведениях.
    /// По этому во главе всего стоит абстрактный класс Learning с одним методом Learn. Его имплиментация реализована в классе Education где он определит набор действий что будут общими для наследников и вызовет всех их в методе Learn.
    /// В наследниках будут реализованы методы Enter,Pass...
    /// В программе мы создали заведение и просто учимся. Learning->Education_School / University
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            University university = new University();

            school.Learn();
            university.Learn();

            Console.Read();
        }
    }
}
