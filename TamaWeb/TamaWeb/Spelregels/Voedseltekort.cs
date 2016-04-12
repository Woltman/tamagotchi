using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamaWeb.Models;

namespace TamaWeb.Spelregels
{
    public class Voedseltekort : Spelregel
    {
        public Voedseltekort()
        {
            Order = 100;
        }
        public override int Order { get; set; }
        public override void ExecuteSpelregel(Tamagotchi tamagotchi, int ticks)
        {
            if(tamagotchi.Hunger >= 100)
            {
                tamagotchi.IsAlive = false;
            }
        }
    }
}