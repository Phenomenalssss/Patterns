using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace HomeMediator
{
    public class Device
    {
        protected IMediator _mediator;

        public Device(IMediator mediator = null)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
