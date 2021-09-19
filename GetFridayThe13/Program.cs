using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFridayThe13
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime cur;
            DateTime[] dayArray = new System.DateTime[17];
            int totalDays = 3650;
            int dayArrayCount = 0;
            for (int day = 1; day < totalDays; day++)
            {
                cur = today.AddDays(day);
                if (IsFriday13(cur))
                {
                    dayArray[dayArrayCount] = cur;
                    dayArrayCount++;
                }
            }

            foreach (DateTime dt in dayArray)
            {
                Console.WriteLine(dt.ToShortDateString());
            }
            Console.WriteLine($"dayArraycount = {dayArrayCount}");
            Console.ReadKey();
        }

        private static bool IsFriday13(DateTime day)
        {
            if (day.DayOfWeek == System.DayOfWeek.Friday && day.Day == 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
