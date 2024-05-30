using TrafficLight.States;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        Light m_trafficLight;
        System.Windows.Forms.Timer m_timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            m_trafficLight = new Light(new GreenLight());
            m_timer.Interval = 100;
            m_timer.Tick += new EventHandler(timer_Tick);
            m_timer.Start();
            InitializeComponent();
            updateLight();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void updateLight()
        {
            LightImage.Image = m_trafficLight.BeamLight();
            switchLabel.Text = m_trafficLight.GetButtonText();
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            m_trafficLight.currentTime++;
            if (m_trafficLight.currentTime >= m_trafficLight.GetDuration())
            {
                m_trafficLight.JumpToNextState();
                updateLight();
                m_trafficLight.currentTime = 0;
            }
            timerLabel.Text = m_trafficLight.currentTime.ToString();
        }

        private void switchToNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_trafficLight.JumpToNextState();
            updateLight();
        }
    }
}
