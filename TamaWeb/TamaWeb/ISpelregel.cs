using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tama.Contract;
using TamaWeb.Models;

namespace TamaWeb
{
    public interface ISpelregel
    {
        int Order { get; set; }
        void ExecuteSpelregel(Tamagotchi tamagotchi, int ticks);
        void ExecuteSpelregelAction(Tamagotchi tamagotchi);
                
    }
}
