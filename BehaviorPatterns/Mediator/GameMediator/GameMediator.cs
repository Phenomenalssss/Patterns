using System;
using System.Collections.Generic;
using System.Text;
using Players;
using IMediators;

namespace GameMediators
{
    public class GameMediator : IMediator
    {
        private Player _player;
        private Player _enemy;

        public GameMediator(Player player, Player enemy)
        {
            _player = player;
            _player.SetMediator(this);
            _enemy = enemy;
            _enemy.SetMediator(this);
        }

        public void Notify(Player player, string action)
        {
            if (action == "Attack")
            {
                if (player == _player)
                {
                    _player.TakeDamage(10);
                    Console.WriteLine($"Игрок {_enemy.Name} ({_enemy.Health}) проводит атаку на игрока {player.Name} ({player.Health})");
                }
                else if (player == _enemy)
                {
                    _enemy.TakeDamage(10);
                    Console.WriteLine($"Игрок {_player.Name} ({_player.Health}) проводит атаку на игрока {player.Name} ({player.Health})");
                }
            }

            if (action == "CastSpell")
            {
                if (player == _player)
                {
                    _player.TakeDamage(25);
                    Console.WriteLine($"Игрок {_enemy.Name} ({_enemy.Health}) использует заклинание на игрока {player.Name} ({player.Health})");
                }
                else if (player == _enemy)
                {
                    _enemy.TakeDamage(25);
                    Console.WriteLine($"Игрок {_player.Name} ({_player.Health}) использует заклинание на игрока {player.Name} ({player.Health})");
                }
            }
        }
    }
}