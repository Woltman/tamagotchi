using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamaWeb.Models;

namespace TamaWeb.Spelregels
{
    public class Munchies : Spelregel
    {
        public Munchies()
        {
            Order = 50;
        }
        public override int Order { get; set; }
        public override void ExecuteSpelregel(Tamagotchi tamagotchi, int ticks)
        {
            if(tamagotchi.Boredom > 80)
            {
                tamagotchi.Hunger += ticks * 5;
            }
        }
    }
}