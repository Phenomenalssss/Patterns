using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy.Quack
{
    public class MuteQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("<< тишина >>");
        }
    }
}
