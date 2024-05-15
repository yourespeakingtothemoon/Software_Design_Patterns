using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoveMePlease.Interfaces;

namespace MoveMePlease
{
    internal class Controller
    {
        ICommand _command;

        List<ICommand> _commandStack = new List<ICommand>();

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
            _commandStack.Add(_command);
        }

        public void Undo()
        {
            if (_commandStack.Count == 0)
            {
                return;
            }

            _commandStack[_commandStack.Count - 1].Undo();
            _commandStack.RemoveAt(_commandStack.Count - 1);
        }
    }
}
