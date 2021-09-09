using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsProgram.Colors;

namespace TrafficLightsProgram
{
    class TrafficLights
    {
        IColor[] _colors = new IColor[3];
        int _currentColorIndex;

        public TrafficLights()
        {
            _colors[0] = new RedColor();
            _colors[1] = new YellowColor();
            _colors[2] = new GreenColor();
        }

        public string CurrentColorToString()
        {
            return _colors[_currentColorIndex].ColorToString();
        }

        public void ChangeColorToNextColor()
        {
            if (_currentColorIndex == _colors.Length - 1)
                _currentColorIndex = 0;
            else
                _currentColorIndex += 1;
        }
    }
}
