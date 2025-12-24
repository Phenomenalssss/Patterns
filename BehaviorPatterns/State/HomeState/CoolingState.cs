using System;
using System.Collections.Generic;
using System.Text;

namespace HomeState
{
    public class CoolingState : State
    {
        public override State Handle(ClimateSystem climateSystem)
        {
            if (climateSystem.Temperature > 25)
            {
                return this;
            }
            else if (climateSystem.Temperature < 20)
            {
                return new HeatingState();
            }
            else
            {
                return new ComfortState();
            }
        }

        public override void Info()
        {
            Console.WriteLine("Охлаждение включено");
        }
    }
}
