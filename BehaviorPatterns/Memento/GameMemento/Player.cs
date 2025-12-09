using GameMemento;
using IMementos;
using Locations;

namespace Players
{
    public class Player
    {
        public string Name { get; private set; }
        private int _health = 100;
        private int _experience = 0;
        private Location _location;
        private State _state;

        public Player(string name)
        {
            Name = name;
            _location = new Location(0, 0, 0);
            _state = new State(_health, _experience, _location, "Create");
        }

        public Player(string name, Location location)
        {
            Name = name;
            _location = location;
            _state = new State(_health, _experience, _location, "Create With LOC");
        }

        public void Cure()
        {
            if (_health >= 100)
            {
                Console.WriteLine("У вас максимальное здоровье");
                return;
            }

            _health += 10;
            Console.WriteLine("Вы излечили себя");
            _state = new State(_health, _experience, new Location(_location.X, _location.Y, _location.Z), "Cure HP");
        }

        public void Hurt()
        {
            if (_health <= 0)
            {
                Console.WriteLine("У вас минимальное здоровье");
                return;
            }

            _health -= 10;
            Console.WriteLine("Вы повредили себя");
            _state = new State(_health, _experience, new Location(_location.X, _location.Y, _location.Z), "Hurt HP");
        }

        public void GetExperience(int exp)
        {
            _experience += exp;
            Console.WriteLine("Вы получили опыт");
            _state = new State(_health, _experience, new Location(_location.X, _location.Y, _location.Z), "Get EXP");
        }

        public void LoseExperience(int exp)
        {
            _experience -= exp;
            Console.WriteLine("Вы потеряли опыт");
            _state = new State(_health, _experience, new Location(_location.X, _location.Y, _location.Z), "Lose EXP");
        }

        public void ChangeLocation(int x, int y, int z)
        {
            _location = _location.Change(x, y, z);
            _state = new State(_health, _experience, _location, "Change LOC");
        }

        public IMemento Save()
        {
            return new PlayerMemento(_state);
        }

        public void Restore(IMemento memento)
        {
            if (!(memento is PlayerMemento))
            {
                throw new Exception("Неизвестный класс: " + memento.ToString());
            }

            _state = memento.GetState();
            Console.WriteLine($"Восстановление состояния {_state.Get()}");
        }
    }
}
