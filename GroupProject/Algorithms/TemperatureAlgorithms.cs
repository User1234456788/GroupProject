using GroupProject.Sernsors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Algorithms
{
    internal class TemperatureAlgorithms : IAlgorithm
    {
        double temperature = 0;
        public async Task runAlgotithm(double valueFromSensor)
        {
            double temperature = processData(valueFromSensor);
            this.temperature = temperature;
            Task.WaitAny();
        }

        public SaveData getAlgorithmResult(double valueFromSensor)
        {
            runAlgotithm(valueFromSensor);
            DateTime timeNow = DateTime.Now;
            SaveData saveData = new SaveData();
            saveData.time = timeNow;
            saveData.value = this.temperature;

            return saveData;
        }


        public double processData(double sensorMark)
        {
            //Function Algorithm work : 24sin(0.006x)
            //return values from (-24) to 24
            return 24 * Math.Sin(0.006 * sensorMark);
        }
    }
}
