using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamaWeb.Models
{
    public class GameClockMin : IGameClock
    {
        public int GetTicks(DateTime creationDate, int age)
        {
            int currentAge = (int)DateTime.UtcNow.Subtract(creationDate).TotalMinutes;
            return currentAge-age;
        }
    }
}