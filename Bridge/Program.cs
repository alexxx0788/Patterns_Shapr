using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bridge.structure;

namespace Bridge
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/4.6.php
    /// Мост (Bridge) - структурный шаблон проектирования, который позволяет отделить абстракцию от реализации таким образом,
    /// чтобы и абстракцию, и реализацию можно было изменять независимо друг от друга.
    /// 
    /// Мы стоим мтос между сузностями прораммист-тип программиста-язык.
    /// Programmer это абстрактный класс, его наследники это FreelanceProgrammer и CorporateProgrammer. На вход он принимает язык и таким образом строится мост.
    /// Таким образом мы можем динамически изменить язык на котором программист будет писать.
    ///  </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // создаем нового программиста, он работает с с++
            Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();
            // пришел новый заказ, но теперь нужен c#
            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();

            Console.Read();
        }
    }
}
