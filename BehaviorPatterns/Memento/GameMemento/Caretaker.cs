using IMementos;
using Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMemento
{
    public class Caretaker
    {
        private Player _player;
        Stack<IMemento> _mementos = new Stack<IMemento>();

        public Caretaker(Player player)
        {
            _player = player;
        }

        public void Backup()
        {
            Console.WriteLine(">>> Сохранение состояния игрока...");
            _mementos.Push(_player.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                Console.WriteLine("Ещё нет сохраненных состояний");
                return;
            }

            var memento = _mementos.Pop();
            Console.WriteLine($"Откат к прошлому состоянию...");

            try
            {
                _player.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            if (_mementos.Count == 0)
            {
                Console.WriteLine($"История состояний игрока {_player.Name} пуста");
                return;
            }

            Console.WriteLine($"История состояний игрока {_player.Name}:");
            foreach(var memento in _mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
