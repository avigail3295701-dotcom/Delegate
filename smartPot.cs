using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegate.Program;

namespace Delegate
{
    internal class smartPot
    {
        public event Kitchen OnDishReady;
        public void StartCooking(string dish, int min)
        {
            for (int i = 0; i < min; i++)
            {
                Console.WriteLine("עברה דקה");
            }
            Console.WriteLine("הבישול הסתיים");
            OnDishReady?.Invoke(dish, min);
        }
    }
}
