using Players;
using Locations;
using System.Globalization;
using GameMemento;

namespace ProgramMemento
{
    class ProgramMemento
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите никнейм игрока = ");
            string name = Console.ReadLine();
            while(name.IsWhiteSpace() || name.Length == 0)
            {
                Console.Write("Ошибка. Введите никнейм игрока = ");
                name = Console.ReadLine();
            }

            Player player1 = new Player(name);

            Caretaker caretaker1 = new Caretaker(player1);

            caretaker1.ShowHistory();

            caretaker1.Backup();
            player1.Hurt();
            caretaker1.Backup();
            player1.Hurt();
            caretaker1.Backup();
            player1.Hurt();
            caretaker1.Backup();
            player1.Hurt();
            caretaker1.Backup();
            player1.Cure();
            caretaker1.Backup();
            player1.GetExperience(2643);
            caretaker1.Backup();
            player1.LoseExperience(132);
            caretaker1.Backup();

            player1.ChangeLocation(100, 200, 300);
            caretaker1.Backup();
            player1.ChangeLocation(-40, -20, 30);
            caretaker1.Backup();

            caretaker1.ShowHistory();

            caretaker1.Undo();
            caretaker1.ShowHistory();
            caretaker1.Undo();
            caretaker1.Undo();
            caretaker1.Undo();
            caretaker1.ShowHistory();
        }
    }
}