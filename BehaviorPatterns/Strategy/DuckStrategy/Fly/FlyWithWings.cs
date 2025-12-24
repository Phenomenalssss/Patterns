using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy.Fly
{
    public class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Я лечу с крыльями");
        }
    }
}
