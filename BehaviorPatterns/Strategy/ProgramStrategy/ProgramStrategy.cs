using DuckStrategy;
using DuckStrategy.Ducks;
using DuckStrategy.Fly;
using DuckStrategy.Quack;

namespace ProgramStrategy
{
    class Program
    {
        public static void Main(string[] args)
        {
            RubberDuck rubberDuck = new RubberDuck();
            MallardDuck mallardDuck = new MallardDuck();
            DecoyDuck decoyDuck = new DecoyDuck();

            List<Duck> ducks = new List<Duck>() { rubberDuck, mallardDuck, decoyDuck };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformFly();
                duck.PerformQuack();
                duck.Swim();
                Console.WriteLine("-----------------------------");
            }

            mallardDuck.Display();
            mallardDuck.SetFly(new FlyNoWay());
            mallardDuck.PerformFly();

            mallardDuck.SetQuack(new Squack());
            mallardDuck.PerformQuack();
        }
    }
}