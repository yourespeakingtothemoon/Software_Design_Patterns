using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoveMePlease.Interfaces;

namespace MoveMePlease.ConcreteCommands
{
    internal class GoDown : ICommand
    {
        private Receiver _receiver;

        public GoDown(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.MoveDown();
        }
        
        public void Undo()
        {
            _receiver.MoveUp();
        }
    }
}
