using GameMemento;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMementos
{
    public interface IMemento
    {
        string GetName();

        DateTime GetDate();

        State GetState();
    }
}
