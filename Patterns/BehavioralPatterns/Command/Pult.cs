using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns.Command
{
    class Pult
    {
        ICommand command;

        public Pult() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void PressButton()
        {
            command.Execute();
        }
        public void PressUndo()
        {
            command.Undo();
        }
    }
}
