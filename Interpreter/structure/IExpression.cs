using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.structure
{
    // интерфейс интерпретатора
    interface IExpression
    {
        int Interpret(Context context);
    }
}
