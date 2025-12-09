using System;
using System.Collections.Generic;
using System.Text;
using IMementos;

namespace GameMemento
{
    public class PlayerMemento : IMemento
    {
        private State _state;
        private DateTime _date;

        public PlayerMemento(State state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        public State GetState()
        {
            return _state;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public string GetName()
        {
            return $"{_date} >>> {_state.Get()}";
        }
    }
}
