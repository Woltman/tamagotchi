using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tama.Contract;
using TamaWeb.Models;

namespace TamaWeb.Spelregels
{
    public class Slaaptekort : Spelregel
    {
        public Slaaptekort()
        {
            Order = 100;
        }
        public override int Order { get; set; }
        public override void ExecuteSpelregel(Tamagotchi tamagotchi, int ticks)
        {
            if(tamagotchi.Sleep >= 100)
            {
                tamagotchi.IsAlive = false;
            }
        }
    }
}