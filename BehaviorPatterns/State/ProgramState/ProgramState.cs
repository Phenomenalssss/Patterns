using HomeState;

namespace ProgramState
{
    class Program
    {
        public static void Main(string[] args)
        {
            ClimateSystem climateSystem = new ClimateSystem(new ComfortState());

            int again = 1;
            while (again != 0)
            {
                int temperature = new Random().Next(18, 28);
                climateSystem.Temperature = temperature;
                Console.WriteLine($"Текущая температура = {climateSystem.Temperature}");
                climateSystem.CheckTemperature();
                Console.WriteLine("Повторить? (1 - да, 0 - нет)");
                again = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}