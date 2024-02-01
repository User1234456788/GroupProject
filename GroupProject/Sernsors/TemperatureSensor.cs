using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupProject.Sernsors
{
    internal class TemperatureSensor : ISensor
    {
        string functionName = "(8sin(0.3x-3)+8)*64";
        private bool run_sensor = true;
        private int interval = 1000;//ms

        public  delegate double callSensor();
        private double sensormark{ get; set; }  

        public double getSensorResult()
        {
            return sensormark;
        }

        public void stopSensor()
        {
            this.run_sensor = false;
        }

        public async Task StartSensor()
        {
            int counter = 0;
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            while (run_sensor)
            {
                counter += 1;

                if (counter > 60){ 
                    counter = 0; 
                }
                Random rnd = new Random();
                double temperature = TemperatureFunction(counter);
                sensormark = temperature;
                await Task.Delay(interval);
            }
            stopwatch.Stop();

        } 

        private double TemperatureFunction(int nowTime)
        {
            //return values from 0 - 1024
            return 64 * (8 * Math.Sin(0.11 * nowTime - 3) + 8);
        }

    }
}
