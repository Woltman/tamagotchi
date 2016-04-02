using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TamaWeb.Models
{
    public class TamagotchiContext : DbContext
    {      
        public DbSet<Tamagotchi> Tamagotchis { get; set; }
    } 
}