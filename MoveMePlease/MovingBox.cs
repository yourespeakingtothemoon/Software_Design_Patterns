using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveMePlease
{
    public partial class MovingBox : Form
    {

        private MoveMePlease.Controller controller = new Controller();
        private MoveMePlease.Receiver receiver;

        public MovingBox()
        {
            InitializeComponent();
            receiver = new Receiver(m_movingbutton);
        }

        private void SelfMovingWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //right
            controller.SetCommand(new MoveMePlease.ConcreteCommands.GoRight(this.receiver));
            controller.ExecuteCommand();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //this is the box that will move
            ProcessStartInfo startInfo = new ProcessStartInfo { FileName = "https://christiandahl.dev", UseShellExecute = true };
            Process.Start(startInfo);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //up
            controller.SetCommand(new MoveMePlease.ConcreteCommands.GoUp(this.receiver));
            controller.ExecuteCommand();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //down
            controller.SetCommand(new MoveMePlease.ConcreteCommands.GoDown(this.receiver));
            controller.ExecuteCommand();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //yellow

            controller.SetCommand(new MoveMePlease.ConcreteCommands.ChangeColor(this.receiver, Color.Yellow));
            controller.ExecuteCommand();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //undo
            controller.Undo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //purple
            controller.SetCommand(new MoveMePlease.ConcreteCommands.ChangeColor(this.receiver, Color.Purple));
            controller.ExecuteCommand();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //red
            controller.SetCommand(new MoveMePlease.ConcreteCommands.ChangeColor(this.receiver, Color.Red));
            controller.ExecuteCommand();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //left
            controller.SetCommand(new MoveMePlease.ConcreteCommands.GoLeft(this.receiver));
            controller.ExecuteCommand();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //white
            controller.SetCommand(new MoveMePlease.ConcreteCommands.ChangeColor(this.receiver, Color.White));
            controller.ExecuteCommand();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //blue
            controller.SetCommand(new MoveMePlease.ConcreteCommands.ChangeColor(this.receiver, Color.Blue));
            controller.ExecuteCommand();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //orange
            controller.SetCommand(new MoveMePlease.ConcreteCommands.ChangeColor(this.receiver, Color.Orange));
            controller.ExecuteCommand();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //green
            controller.SetCommand(new MoveMePlease.ConcreteCommands.ChangeColor(this.receiver, Color.Green));
            controller.ExecuteCommand();
        }
    }
}
