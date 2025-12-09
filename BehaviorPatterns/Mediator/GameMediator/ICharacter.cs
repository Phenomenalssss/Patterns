using System;
using System.Collections.Generic;
using System.Text;
using IMediators;

namespace ICharacters
{
    public interface ICharacter
    {
        void SetMediator(IMediator mediator);
    }
}
