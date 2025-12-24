using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy.Quack
{
    public class Kquack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Кря-кря");
        }
    }
}
