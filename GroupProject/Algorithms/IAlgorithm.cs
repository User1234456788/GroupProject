using GroupProject.Sernsors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Algorithms
{
    internal interface IAlgorithm
    {
        double getSensorData(DataTemplate data);

        double processData(double sensorMark);

        double getAlgorithmResult(DataTemplate data);
    }
}
