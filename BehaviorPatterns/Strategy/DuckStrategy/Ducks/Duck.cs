using DuckStrategy.Fly;
using DuckStrategy.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy.Ducks
{
    public abstract class Duck
    {
        private IFlyable _flyable;
        private IQuackable _quackable;

        public Duck(IFlyable flyable, IQuackable quackable)
        {
            _flyable = flyable;
            _quackable = quackable;
        }

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("Я могу плавать");
        }

        public void PerformFly()
        {
            _flyable.Fly();
        }

        public void PerformQuack()
        {
            _quackable.Quack();
        }

        public void SetFly(IFlyable flyable)
        {
            _flyable = flyable;
        }

        public void SetQuack(IQuackable quackable)
        {
            _quackable = quackable;
        }
    }
}
