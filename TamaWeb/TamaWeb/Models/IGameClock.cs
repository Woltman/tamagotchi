using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamaWeb.Models
{
    public interface IGameClock
    {
        int GetTicks(DateTime creationDate, int age);
    }
}
