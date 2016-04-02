using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tama.Contract;
using TamaWeb.Models;

namespace TamaWeb
{
    public class Vermoeidheid : ISpelregel
    {
        public void ExecuteSpelregel(Tamagotchi tamagotchi, int ticks)
        {
            //elk uur + 5 bij Sleep
            tamagotchi.Sleep += ticks * 5;

            if(tamagotchi.Sleep >= 100 && tamagotchi.Health >= 20)
            {
                tamagotchi.IsAlive = false;
            }
            
        }
    }
}