using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLight.Interfaces;

namespace TrafficLight.States
{
    internal class YellowLight : IState
    {
        public float Duration { get; set; } = 10;
        public Bitmap BeamLight()
        {
            return TrafficLight.Properties.Resources.yellow;
        }

        public IState SetNextState()
        {
            return new RedLight();
        }

        public string GetLightName()
        {
            return "Yellow";
        }
    }
}
