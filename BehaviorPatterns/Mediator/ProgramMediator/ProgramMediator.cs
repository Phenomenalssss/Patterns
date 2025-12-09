using GameMediators;
using Players;
using IMediators;

namespace ProgramMediator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите никнейм первого игрока = ");
            string name = Console.ReadLine();
            while (name.IsWhiteSpace() || name.Length == 0)
            {
                Console.Write("Ошибка. Введите никнейм первого игрока = ");
                name = Console.ReadLine();
            }
            Player player = new Player(name);
            Console.Write("Введите никнейм второго игрока = ");
            name = Console.ReadLine();
            while (name.IsWhiteSpace() || name.Length == 0)
            {
                Console.Write("Ошибка. Введите никнейм второго игрока = ");
                name = Console.ReadLine();
            }
            Player enemy = new Player(name);

            IMediator mediator = new GameMediator(player, enemy);

            player.Attack(player);
            player.CastSpell(player);

            player.Attack(enemy);
            enemy.Attack(player);
            player.CastSpell(enemy);
            player.CastSpell(enemy);
            player.CastSpell(enemy);
            player.CastSpell(enemy);
            player.CastSpell(enemy);
            enemy.Attack(player);
        }
    }
}