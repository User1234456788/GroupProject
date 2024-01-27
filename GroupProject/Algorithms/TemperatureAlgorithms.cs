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
        public double getAlgorithmResult(DataTemplate data)
        {
            double sensorData = getSensorData(data);
            double temperature = processData(sensorData);
            return temperature;
        }

        public double getSensorData(DataTemplate data)
        {
            return data.data;
        }

        public double processData(double sensorMark)
        {
            //Function Algorithm work : 24sin(0.006x)
            //return values from (-24) to 24
            return 24 * Math.Sin(0.006 * sensorMark);
        }
    }
}
