using CaffeineBeverageTemplateMethod;

namespace ProgramTemplateMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            Tea tea = new Tea();

            Console.WriteLine("----- Кофе -----");
            coffee.PrepareRecipe();

            Console.WriteLine();

            Console.WriteLine("----- Чай -----");
            tea.PrepareRecipe();
        }
    }
}