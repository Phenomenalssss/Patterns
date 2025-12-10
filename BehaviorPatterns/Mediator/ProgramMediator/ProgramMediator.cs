using HomeMediator;

namespace ProgramMediator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Alarm alarm = new Alarm();
            Calendar calendar = new Calendar();
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            SmartBlinds smartBlinds = new SmartBlinds();

            new DeviceMediator(alarm, coffeeMachine, calendar, smartBlinds);

            calendar.CheckHoliday();
            Console.WriteLine("-----");
            alarm.Play();
        }
    }
}