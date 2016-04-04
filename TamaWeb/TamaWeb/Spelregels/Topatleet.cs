using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamaWeb.Models;

namespace TamaWeb.Spelregels
{
    public class Topatleet : Spelregel
    {
        public Topatleet()
        {
            Order = 150;
        }
        public override int Order { get; set; }
        public override void ExecuteSpelregel(Tamagotchi tamagotchi, int ticks)
        {
            tamagotchi.IsAlive = (tamagotchi.Health < 20);
        }
    }
}