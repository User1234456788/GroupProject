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
        Task runAlgotithm(double valueFromSensor);

        SaveData getAlgorithmResult(double valueFromSensor);

        double processData(double sensorMark);
    }
}
