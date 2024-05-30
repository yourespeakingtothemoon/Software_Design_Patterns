using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLight.Interfaces;

namespace TrafficLight
{
    internal class Light
    {
        private IState _state;
        private IState _nextstate;

        public float currentTime = 0;

        public Light(IState state)
        {
            _state = state;
            _nextstate = _state.SetNextState();
        }

        public float GetDuration()
        {
            return _state.Duration;
        }

        public Bitmap BeamLight()
        {
            return _state.BeamLight();
        }

        public void ChangeState(IState state)
        {
            _state = state;
            _nextstate = _state.SetNextState();

        }

        public void JumpToNextState()
        {
            _state = _nextstate;
            _nextstate = _state.SetNextState();
        }

        public string GetButtonText()
        {
            return "Switch to "+ _nextstate.GetLightName();
        }
    }
}
