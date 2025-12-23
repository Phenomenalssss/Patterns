using System;
using System.Collections.Generic;
using System.Text;

namespace HomeState
{
    public class ComfortState : State
    {
        public override void Handle(ClimateSystem climateSystem)
        {
            if (climateSystem.Temperature < 20)
            {
                climateSystem.SetState(new HeatingState());
            }
            else if (climateSystem.Temperature > 25)
            {
                climateSystem.SetState(new CoolingState());
            }
            else
            {
                Info();
            }
        }

        public override void Info()
        {
            Console.WriteLine("Комфортная температура");
        }
    }
}
