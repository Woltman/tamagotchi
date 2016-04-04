using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tama.Contract;
using TamaWeb.Models;
using TamaWeb.Spelregels;

namespace TamaWeb
{
    public class Vermoeidheid : Spelregel
    {
        public Vermoeidheid()
        {
            Order = 0;
        }
        public override int Order { get; set; }
        public override void ExecuteSpelregel(Tamagotchi tamagotchi, int ticks)
        {
            //elk uur + 5 bij Sleep
            tamagotchi.Sleep += ticks * 5;
        }
    }
}