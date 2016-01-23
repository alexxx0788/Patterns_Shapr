using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.structure
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
