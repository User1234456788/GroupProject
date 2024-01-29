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
        double getSensorData(SaveData data);

        double processData(double sensorMark);

        SaveData getAlgorithmResult(SaveData data);
    }
}
