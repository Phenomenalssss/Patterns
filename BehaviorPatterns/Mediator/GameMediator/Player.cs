using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using IMediators;
using ICharacters;

namespace Players
{
    public class Player : ICharacter
    {
        private IMediator _mediator;
        private bool _isDead = false;
        public string Name { get; private set; }
        public int Health { get; private set; } = 100;

        public Player(string name, IMediator mediator = null)
        {
            Name = name;
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        private bool IsOtherPlayer(Player player)
        {
            return this == player;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                _isDead = true;
            }
        }

        public void Attack(Player enemy)
        {
            if (_isDead)
            {
                Console.WriteLine("Вы мертвы");
                return;
            }
            if (IsOtherPlayer(enemy))
            {
                Console.WriteLine("Вы не можете атаковать самого себя");
                return;
            }
            if (enemy._isDead)
            {
                Console.WriteLine("Противник уже мёртв");
                return;
            }
            _mediator.Notify(enemy, "Attack");
        }

        public void CastSpell(Player enemy)
        {
            if (_isDead)
            {
                Console.WriteLine("Вы мертвы");
                return;
            }
            if (IsOtherPlayer(enemy))
            {
                Console.WriteLine("Вы не можете использовать заклинание на самого себя.");
                return;
            }
            if (enemy._isDead)
            {
                Console.WriteLine("Противник уже мёртв");
                return;
            }
            _mediator.Notify(enemy, "CastSpell");
        }
    }
}
