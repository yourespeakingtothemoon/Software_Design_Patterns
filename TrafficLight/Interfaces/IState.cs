using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight.Interfaces
{
    internal interface IState
    {
        float Duration { get; set; }
        public Bitmap BeamLight();
        public IState SetNextState();

        public string GetLightName();
    }
}
