using Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMemento
{
    public class State
    {
        private int _health;
        private int _expirience;
        private Location _location;
        private string _name;

        public State(int health, int experience, Location location, string name)
        {
            _health = health;
            _expirience = experience;
            _location = location;
            _name = name;
        }

        public string Get()
        {
            return $"{_name} (health = {_health}, exp = {_expirience}, loc = {_location.Get()})";
        }
    }
}
