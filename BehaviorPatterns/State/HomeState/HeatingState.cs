using System;
using System.Collections.Generic;
using System.Text;

namespace HomeState
{
    public class HeatingState : State
    {
        public override void Handle(ClimateSystem climateSystem)
        {
            if (climateSystem.Temperature > 25)
            {
                climateSystem.SetState(new CoolingState());
            }
            else if (climateSystem.Temperature < 20)
            {
                Info();
            }
            else
            {
                climateSystem.SetState(new ComfortState());
            }
        }
        public override void Info()
        {
            Console.WriteLine("Обогрев включён");
        }

    }
}
