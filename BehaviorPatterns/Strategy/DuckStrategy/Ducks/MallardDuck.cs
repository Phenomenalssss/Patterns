using System;
using System.Collections.Generic;
using System.Text;
using DuckStrategy.Fly;
using DuckStrategy.Quack;

namespace DuckStrategy.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyable = new FlyWithWings();
            _quackable = new Kquack();
        }

        public override void Display()
        {
            Console.WriteLine("Я дикая утка");
        }
    }
}
