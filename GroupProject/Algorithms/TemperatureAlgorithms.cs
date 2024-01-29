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
        
        public SaveData getAlgorithmResult(SaveData data)
        {
            double sensorData = getSensorData(data);
            data.value = processData(sensorData);
            return data;
        }

        public double getSensorData(SaveData data)
        {
            return data.value;
        }

        public double processData(double sensorMark)
        {
            //Function Algorithm work : 24sin(0.006x)
            //return values from (-24) to 24
            return 24 * Math.Sin(0.006 * sensorMark);
        }
    }
}
