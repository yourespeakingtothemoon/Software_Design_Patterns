using MoveMePlease.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMePlease.ConcreteCommands
{
    internal class ChangeColor : ICommand
    {
        Color _color;
        Color _prev;
        Receiver _receiver;

        public ChangeColor(Receiver receiver, Color color)
        {
            _receiver = receiver;
            _color = color;
        }

        public void Execute()
        {
            _prev = _receiver.GetColor();
            _receiver.changeColor(_color);
            
        }

        public Color GetColor()
        {
            return _color;
        }

        public void Undo()
        {
            _receiver.changeColor(_prev);
        }
    }
}
