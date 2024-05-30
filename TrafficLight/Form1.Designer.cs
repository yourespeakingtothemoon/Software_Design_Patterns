namespace TrafficLight
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LightImage = new PictureBox();
            menuStrip1 = new MenuStrip();
            switchLabel = new ToolStripMenuItem();
            timerLabel = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)LightImage).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LightImage
            // 
            LightImage.Image = Properties.Resources.green;
            LightImage.Location = new Point(-83, 27);
            LightImage.Name = "LightImage";
            LightImage.Size = new Size(442, 553);
            LightImage.SizeMode = PictureBoxSizeMode.Zoom;
            LightImage.TabIndex = 0;
            LightImage.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { switchLabel, timerLabel });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(280, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // switchLabel
            // 
            switchLabel.Name = "switchLabel";
            switchLabel.Size = new Size(96, 20);
            switchLabel.Text = "Switch to Next";
            switchLabel.Click += switchToNextToolStripMenuItem_Click;
            // 
            // timerLabel
            // 
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(25, 20);
            timerLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 577);
            Controls.Add(LightImage);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Traffic Light";
            ((System.ComponentModel.ISupportInitialize)LightImage).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LightImage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem switchLabel;
        private ToolStripMenuItem timerLabel;
    }
}
