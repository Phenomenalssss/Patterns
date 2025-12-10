using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMediator
{
    public class CoffeeMachine : Device
    {
        public void Make()
        {
            Console.WriteLine("Приготовлен кофе");
        }
    }
}
