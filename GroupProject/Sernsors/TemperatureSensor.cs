using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Sernsors
{
    internal class TemperatureSensor : ISensor
    {
        string functionName = "(8sin(0.3x-3)+8)*64";

        int Interval = 5; //sensor updates each 5s

        public SaveData GetData()
        {
            SaveData data = new SaveData();
            data.value = GatherData();
            data.time = DateTime.Now;
            return data;
        }

        public double GatherData()
        {

            DateTime nowHours = DateTime.Now;
            double nowseconds = DateTime.Now.Second;


            return TemperatureFunction(nowseconds);
        }

        private double TemperatureFunction(double nowTime)
        {
            //return values from 0 - 1024
            return 64 * (8 * Math.Sin(0.11 * nowTime - 3) + 8);
        }

    }
}
