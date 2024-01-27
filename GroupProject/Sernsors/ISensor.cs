using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Sernsors
{
    internal interface ISensor
    {
        DataTemplate GetData();

        double GatherData();

    }
}
