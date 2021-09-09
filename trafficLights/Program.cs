using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsProgram.Colors;

namespace TrafficLightsProgram
{
    class Program
    {
        public static async Task StartTrafficLightCycle(TrafficLightsClass trafficLights, int delayBeetwenColorChanges)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(trafficLights.CurrentColorToString());
                
                trafficLights.ChangeColorToNextColor();
                await Task.Delay(delayBeetwenColorChanges);
            }
        }
        static void Main(string[] args)
        {
            TrafficLightsClass trafficLights = new TrafficLightsClass();

            StartTrafficLightCycle(trafficLights, 1000);

            Console.ReadKey();
            
        }
    }
}
