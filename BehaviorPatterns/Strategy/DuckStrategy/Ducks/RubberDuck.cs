using System;
using System.Collections.Generic;
using System.Text;
using DuckStrategy.Fly;
using DuckStrategy.Quack;

namespace DuckStrategy.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new FlyNoWay(), new Squack()) { }

        public override void Display()
        {
            Console.WriteLine("Я резиновая утка");
        }
    }
}
