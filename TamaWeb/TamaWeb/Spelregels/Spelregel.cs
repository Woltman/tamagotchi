using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamaWeb.Models;

namespace TamaWeb.Spelregels
{
    public abstract class Spelregel : ISpelregel
    {
        public virtual int Order { get; set; }        

        public virtual void ExecuteSpelregel(Tamagotchi tamagotchi, int ticks)
        {
            
        }

        public virtual void ExecuteSpelregelAction(Tamagotchi tamagotchi)
        {
            
        }
    }
}