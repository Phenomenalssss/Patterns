using System;
using System.Collections.Generic;
using System.Text;
using DuckStrategy.Fly;
using DuckStrategy.Quack;

namespace DuckStrategy.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck() : base(new FlyNoWay(), new MuteQuack()) { }

        public override void Display()
        {
            Console.WriteLine("Я утка-приманка");
        }
    }
}
