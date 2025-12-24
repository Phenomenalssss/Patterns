using System;
using System.Collections.Generic;
using System.Text;

namespace HomeState
{
    public class ComfortState : State
    {
        public override State Handle(ClimateSystem climateSystem)
        {
            if (climateSystem.Temperature < 20)
            {
                return new HeatingState();
            }
            else if (climateSystem.Temperature > 25)
            {
                return new CoolingState();
            }
            else
            {
                return this;
            }
        }

        public override void Info()
        {
            Console.WriteLine("Комфортная температура");
        }
    }
}
