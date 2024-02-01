using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Sernsors
{
    internal interface ISensor
    {
        Task StartSensor();
        void stopSensor();

        double getSensorResult();

    }
}
