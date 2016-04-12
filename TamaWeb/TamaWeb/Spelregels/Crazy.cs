using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tama.Contract;
using TamaWeb.Models;

namespace TamaWeb.Spelregels
{
    public class Crazy : Spelregel
    {
        private Random r;

        public Crazy(Random r)
        {
            this.r = r;
        }

        public Crazy()
        {
            r = new Random();
        }
        public override void ExecuteSpelregelAction(Tamagotchi tamagotchi)
        {
            if(tamagotchi.Health == 100)
            {
                Random rdm = new Random();
                tamagotchi.IsAlive = (rdm.Next(2) < 1);
            }
        }
    }
}