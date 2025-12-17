using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMediator
{
    public class SmartBlinds : Device
    {
        public SmartBlinds(IMediator mediator) : base(mediator) { }

        public void Receive(string action)
        {
            if (action == "Alarm")
            {
                Open();
            }
        }

        public void Open()
        {
            Console.WriteLine("Жалюзи открыты");
        }
    }
}
