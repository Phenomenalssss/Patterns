using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMediator
{
    public class Alarm : Device
    {
        public Alarm(IMediator mediator) : base(mediator) { }

        public void Receive(string action)
        {
            if (action == "AlarmOnTen")
            {
                Set(10);
            }

            if (action == "AlarmOnSix")
            {
                Set(6);
            }
        }

        public void Play()
        {
            Console.WriteLine("Будильник сработал");
            _mediator.Notify(this, "Alarm");
        }

        public void Set(int hour)
        {
            Console.WriteLine($"Будильник установлен на {hour} ч.");
        }
    }
}
