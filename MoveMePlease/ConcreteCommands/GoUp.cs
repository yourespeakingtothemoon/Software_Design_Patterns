using MoveMePlease.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMePlease.ConcreteCommands
{
    internal class GoUp : ICommand
    {
        private readonly Receiver _receiver;

        public GoUp(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.MoveUp();
        }

        public void Undo()
        {
            _receiver.MoveDown();
        }
    }
}
