using System;
using System.Collections.Generic;
using System.Text;

namespace HomeState
{
    public class CoolingState : State
    {
        public override void Handle(ClimateSystem climateSystem)
        {
            if (climateSystem.Temperature > 25)
            {
                Info();
            }
            else if (climateSystem.Temperature < 20)
            {
                climateSystem.SetState(new HeatingState());
            }
            else
            {
                climateSystem.SetState(new ComfortState());
            }
        }

        public override void Info()
        {
            Console.WriteLine("Охлаждение включено");
        }
    }
}
