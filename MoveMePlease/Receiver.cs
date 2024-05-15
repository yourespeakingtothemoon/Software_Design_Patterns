using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMePlease
{
    internal class Receiver
    {
        public Color buttonColor;
        Button box;
        public Receiver(Button btn) { 
            this.box = btn;
        }
     

        public void MoveRight() { 
        
            this.box.Location = new Point(this.box.Location.X + 10, this.box.Location.Y);

        }
        public void MoveLeft() {
            this.box.Location = new Point(this.box.Location.X - 10, this.box.Location.Y);
        
        }
        public void MoveUp() {
            this.box.Location = new Point(this.box.Location.X, this.box.Location.Y - 10);
        
        }
        public void MoveDown() { 
            this.box.Location = new Point(this.box.Location.X, this.box.Location.Y + 10);
        
        }

        public void changeColor(Color color) { 
            buttonColor = color;
            box.BackColor = color;

        }

        public Color GetColor()
        {
            return buttonColor;
        }
     
    }
}
