using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoveMePlease.Interfaces;

namespace MoveMePlease.ConcreteCommands
{
    internal class GoRight : ICommand
    {
        private Receiver _receiver;

        public GoRight(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.MoveRight();
        }
        
        public void Undo()
        {
            _receiver.MoveLeft();
        }
    }
}
