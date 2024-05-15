using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoveMePlease.Interfaces;

namespace MoveMePlease.ConcreteCommands
{
    internal class GoLeft : ICommand
    {
        private Receiver _receiver;

        public GoLeft(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.MoveLeft();
        }
        
        public void Undo()
        {
            _receiver.MoveRight();
        }
    }
}
