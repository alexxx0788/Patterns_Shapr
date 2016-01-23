using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template_Method.structure
{
    abstract class Education : Learning
    {
        public sealed override void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }
        public abstract void Enter();
        public abstract void Study();
        public virtual void PassExams()
        {
            Console.WriteLine("Сдаем выпускные экзамены");
        }
        public abstract void GetDocument();
    }
}
