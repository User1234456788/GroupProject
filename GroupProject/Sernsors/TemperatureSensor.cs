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
        public DataTemplate GetData()
        {
            DataTemplate data = new DataTemplate();
            data.data = GatherData();
            data.functionCollect = this.functionName;
            return data;
        }

        public double GatherData()
        {
            int nowHours = DateTime.Now.Hour;
            int nowMinutes = DateTime.Now.Minute;
         
            double nowTime = nowHours + nowMinutes/60;
            return TemperatureFunction(nowHours);
        }

        private double TemperatureFunction(double nowHour)
        {
            //return values from 0 - 1024
            return 64 * (8 * Math.Sin(0.3 * nowHour - 3) + 8);
        }

    }
}
