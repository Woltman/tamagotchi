using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new TamagotchiClient.TamagotchiServiceClient())
            {
                
                
                Console.WriteLine(client.GetTamagotchi());
                client.Eat();
                Console.WriteLine(client.GetTamagotchi());
                Console.ReadLine();
            }
        }
    }
}
