using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy.Quack
{
    public class Squack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Пи-пи");
        }
    }
}
