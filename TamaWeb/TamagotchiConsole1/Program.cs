using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new TamaService.TamagotchiServiceClient())
            {
                client.AddTamagotchi("Thom");

                var list = client.GetAll();

                foreach(var item in list)
                {
                    Console.WriteLine(item);
                }

                Console.ReadLine();
            }
        }
    }
}
