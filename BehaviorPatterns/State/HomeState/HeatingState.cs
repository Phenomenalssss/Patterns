using System;
using System.Collections.Generic;
using System.Text;

namespace HomeState
{
    public class HeatingState : State
    {
        public override State Handle(ClimateSystem climateSystem)
        {
            if (climateSystem.Temperature > 25)
            {
                return new CoolingState();
            }
            else if (climateSystem.Temperature < 20)
            {
                return this;
            }
            else
            {
                return new ComfortState();
            }
        }
        public override void Info()
        {
            Console.WriteLine("Обогрев включён");
        }

    }
}
