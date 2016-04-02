using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tama.Contract;
using TamaWeb.Models;

namespace TamaWeb.Spelregels
{
    public class Honger : ISpelregel
    {
        public void ExecuteSpelregel(Tamagotchi tamagotchi, int ticks)
        {
            tamagotchi.Hunger += ticks * 5;

            if (tamagotchi.Boredom > 80)
            {
                tamagotchi.Hunger += ticks * 5;
            }

            if (tamagotchi.Hunger >= 100 && tamagotchi.Health >= 20)
            {
                tamagotchi.IsAlive = false;
            }
        }
    }
}