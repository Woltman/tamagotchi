using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tama.Contract;
using TamaWeb.Models;

namespace TamaWeb.Spelregels
{
    public class Verveling : ISpelregel
    {
        public void ExecuteSpelregel(Tamagotchi tamagotchi, int ticks)
        {
            tamagotchi.Boredom += ticks * 15;
       
        }
    }
}