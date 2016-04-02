using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Now.AddMinutes(70).AddSeconds(30));

            var age = (int)DateTime.Now.AddMinutes(71).AddSeconds(60).Subtract(DateTime.UtcNow).TotalMinutes;

            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
