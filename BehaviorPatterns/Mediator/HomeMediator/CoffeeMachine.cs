using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMediator
{
    public class CoffeeMachine : Device
    {
        public CoffeeMachine(IMediator mediator) : base(mediator) { }

        public void Receive(string action)
        {
            if (action == "Alarm")
            {
                Make();
            }
        }

        public void Make()
        {
            Console.WriteLine("Приготовлен кофе");
        }
    }
}
