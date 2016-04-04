using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tama.Contract;
using TamaWeb.Models;

namespace TamaWeb.Spelregels
{
    public class Isolatie : Spelregel
    {
        public Isolatie()
        {
            Order = 0;
        }
        public override int Order { get; set; }
        public override void ExecuteSpelregel(Tamagotchi tamagotchi, int ticks)
        {
            tamagotchi.Health += ticks * 5;
        }
    }
}