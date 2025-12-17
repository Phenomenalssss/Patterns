using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HomeMediator
{
    public class DeviceMediator : IMediator
    {
        private Alarm _alarm;
        private CoffeeMachine _coffeeMachine;
        private Calendar _calendar;
        private SmartBlinds _smartBlinds;

        public DeviceMediator(Alarm alarm, CoffeeMachine coffeeMachine, Calendar calendar, SmartBlinds smartBlinds)
        {
            _alarm = alarm;
            _alarm.SetMediator(this);
            _coffeeMachine = coffeeMachine;
            _coffeeMachine.SetMediator(this);
            _calendar = calendar;
            _calendar.SetMediator(this);
            _smartBlinds = smartBlinds;
            _smartBlinds.SetMediator(this);
        }

        public void Notify(Device device, string action)
        {
            if (device == _calendar)
            {
                _alarm.Receive(action);
            }
            if (device == _alarm)
            {
                _smartBlinds.Receive(action);
                _coffeeMachine.Receive(action);
            }
        }
    }
}
