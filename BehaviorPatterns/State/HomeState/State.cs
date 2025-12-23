using System;
using System.Collections.Generic;
using System.Text;

namespace HomeState
{
    public abstract class State
    {
        protected ClimateSystem _climateSystem;

        public void SetContext(ClimateSystem climateSystem)
        {
            _climateSystem = climateSystem;
        }

        public abstract void Handle(ClimateSystem climateSystem);

        public abstract void Info();
    }
}
