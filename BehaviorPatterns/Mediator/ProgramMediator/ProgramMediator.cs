using HomeMediator;

namespace ProgramMediator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Alarm alarm = new Alarm(null);
            Calendar calendar = new Calendar(null);
            CoffeeMachine coffeeMachine = new CoffeeMachine(null);
            SmartBlinds smartBlinds = new SmartBlinds(null);

            IMediator mediator = new DeviceMediator(alarm, coffeeMachine, calendar, smartBlinds);

            calendar.CheckHoliday();
            Console.WriteLine("-----");
            alarm.Play();
        }
    }
}