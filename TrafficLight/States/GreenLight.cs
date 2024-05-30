using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLight.Interfaces;

namespace TrafficLight.States
{
    internal class GreenLight : IState
    {
        public float Duration { get; set; } = 20;
        public Bitmap BeamLight()
        {
            return TrafficLight.Properties.Resources.green;
        }

        public IState SetNextState()
        {
            return new YellowLight();
        }

        public string GetLightName()
        {
            return "Green";
        }
    }
}
