using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMediator
{
    public class Calendar : Device
    {
        public Calendar(IMediator mediator) : base(mediator) { }

        public void CheckHoliday()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Сегодня выходной день");
                _mediator.Notify(this, "AlarmOnTen");
            }
            else
            {
                Console.WriteLine("Сегодня будний день");
                _mediator.Notify(this, "AlarmOnSix");
            }
        }
    }
}
