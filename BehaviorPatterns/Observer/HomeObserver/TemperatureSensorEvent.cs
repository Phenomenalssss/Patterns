using System;
using System.Collections.Generic;
using System.Text;

namespace HomeObserver
{
    public class TemperatureSensorEvent
    {
        public int Temperature { get; private set; }

        public event Action<int> TemperatureChanged;

        public void ChangeTemperature()
        {
            Temperature = new Random().Next(15, 30);
            Console.WriteLine($"Текущая температура = {Temperature}");
            TemperatureChanged?.Invoke(Temperature);
        }
    }
}
