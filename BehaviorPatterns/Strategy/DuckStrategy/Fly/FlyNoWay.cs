using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy.Fly
{
    public class FlyNoWay : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Я не умею летать");
        }
    }
}
