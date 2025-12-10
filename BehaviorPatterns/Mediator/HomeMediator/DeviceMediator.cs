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
            if (device == _calendar && action == "AlarmOnTen")
            {
                _alarm.Set(10);
            }
            if (device == _calendar && action == "AlarmOnSix")
            {
                _alarm.Set(6);
            }
            if (device == _alarm && action == "SmartBlindsOpen")
            {
                _smartBlinds.Open();
            }
            if (device == _alarm && action == "CoffeeMake")
            {
                _coffeeMachine.Make();
            }
        }
    }
}
