using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamaWeb.Models;

namespace TamaWeb.Spelregels
{
    public class SpelregelEngine
    {
        private readonly IEnumerable<ISpelregel> _regels;
        private readonly IGameClock _gameClock;

        public SpelregelEngine(IEnumerable<ISpelregel> regels, IGameClock gameClock)
        {
            _regels = regels.OrderBy(r => r.Order);
            _gameClock = gameClock;
        }

        public void ExecuteSpelRegels(Tamagotchi tama)
        {
            if (tama.IsAlive)
            {
                var ticks = _gameClock.GetTicks(tama.CreationDate, tama.Age);

                foreach (var regel in _regels)
                {
                    regel.ExecuteSpelregel(tama, ticks);
                }

                tama.Age += ticks;
            }
        }

        public void ExecuteSpelregelActions(Tamagotchi tama)
        {
            if (tama.IsAlive)
            {
                foreach (var regel in _regels)
                {
                    regel.ExecuteSpelregelAction(tama);
                }
            }
        }
    }
}