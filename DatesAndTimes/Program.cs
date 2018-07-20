using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());
            Console.WriteLine(myValue.AddDays(5).ToLongDateString());
            Console.WriteLine(myValue.AddHours(10).ToLongTimeString());
            Console.WriteLine(myValue.Month);

            DateTime myBirthday = new DateTime(1984, 10, 19);
            Console.WriteLine(myBirthday);
            myBirthday = DateTime.Parse("10/19/1984");
            Console.WriteLine(myBirthday);
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
