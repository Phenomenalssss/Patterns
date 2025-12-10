using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMediator
{
    public class Alarm : Device
    {
        public void Play()
        {
            Console.WriteLine("Будильник сработал");
            _mediator.Notify(this, "CoffeeMake");
            _mediator.Notify(this, "SmartBlindsOpen");
        }

        public void Set(int hour)
        {
            Console.WriteLine($"Будильник установлен на {hour} ч.");
        }
    }
}
