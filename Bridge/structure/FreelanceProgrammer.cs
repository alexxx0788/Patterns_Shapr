using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.structure
{
    class FreelanceProgrammer : Programmer
    {
        public FreelanceProgrammer(ILanguage lang)
            : base(lang)
        {
        }
        public override void EarnMoney()
        {
            Console.WriteLine("Получаем оплату за выполненный заказ");
        }
    }
}
