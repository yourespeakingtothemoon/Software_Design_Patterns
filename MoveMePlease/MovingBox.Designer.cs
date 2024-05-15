namespace MoveMePlease
{
    partial class MovingBox
    {

        public Button m_movingbutton;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button12 = new Button();
            button11 = new Button();
            button13 = new Button();
            m_movingbutton = button13;
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(343, 299);
            button1.Name = "button1";
            button1.Size = new Size(91, 163);
            button1.TabIndex = 0;
            button1.Text = ">>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(45, 299);
            button2.Name = "button2";
            button2.Size = new Size(91, 163);
            button2.TabIndex = 1;
            button2.Text = "<<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(154, 489);
            button3.Name = "button3";
            button3.Size = new Size(170, 76);
            button3.TabIndex = 2;
            button3.Text = "vv";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(154, 200);
            button4.Name = "button4";
            button4.Size = new Size(170, 76);
            button4.TabIndex = 3;
            button4.Text = "^^";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.ForeColor = Color.Red;
            button5.Location = new Point(163, 307);
            button5.Name = "button5";
            button5.Size = new Size(42, 42);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Purple;
            button6.Location = new Point(218, 306);
            button6.Name = "button6";
            button6.Size = new Size(42, 42);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Blue;
            button7.Location = new Point(279, 307);
            button7.Name = "button7";
            button7.Size = new Size(42, 42);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Orange;
            button8.Location = new Point(218, 365);
            button8.Name = "button8";
            button8.Size = new Size(42, 42);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(163, 418);
            button9.Name = "button9";
            button9.Size = new Size(42, 42);
            button9.TabIndex = 8;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Green;
            button10.Location = new Point(280, 365);
            button10.Name = "button10";
            button10.Size = new Size(42, 42);
            button10.TabIndex = 9;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Yellow;
            button12.Location = new Point(278, 417);
            button12.Name = "button12";
            button12.Size = new Size(42, 42);
            button12.TabIndex = 11;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(372, 531);
            button11.Name = "button11";
            button11.Size = new Size(94, 76);
            button11.TabIndex = 12;
            button11.Text = "Undo";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button13
            // 
            button13.Location = new Point(236, 79);
            button13.Name = "button13";
            button13.Size = new Size(24, 26);
            button13.TabIndex = 13;
            button13.Click += button13_Click;
            // 
            // MovingBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 622);
            Controls.Add(button13);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MovingBox";
            Text = "SelfMovingWindow";
            Load += SelfMovingWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button12;
        private Button button11;
        private Button button13;
    }
}