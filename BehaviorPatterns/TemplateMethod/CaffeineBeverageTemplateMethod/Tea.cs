using System;
using System.Collections.Generic;
using System.Text;

namespace CaffeineBeverageTemplateMethod
{
    public class Tea : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем лимон");
        }

        protected override void Brew()
        {
            Console.WriteLine("Завариваем чай");
        }
    }
}
