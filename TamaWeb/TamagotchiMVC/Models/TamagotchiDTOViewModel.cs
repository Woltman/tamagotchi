using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using TamagotchiMVC.TamagotchiServiceClient;

namespace TamagotchiMVC.Models
{
    public class TamagotchiDTOViewModel
    {       
        public TamagotchiDTOViewModel(TamagotchiDTO tamagotchiDTO)
        {
            ID = tamagotchiDTO.ID;
            Name = tamagotchiDTO.Name;
            Sleep = tamagotchiDTO.Sleep;
            Boredom = tamagotchiDTO.Boredom;
            Hunger = tamagotchiDTO.Hunger;
            Health = tamagotchiDTO.Health;
            IsAlive = tamagotchiDTO.IsAlive;
            Age = tamagotchiDTO.Age;
            CreationDate = tamagotchiDTO.CreationDate;
            CooldownTill = tamagotchiDTO.CooldownTill;
            
        }

        public int ID { get; set; }

        [DisplayName("Naam")]
        public String Name { get; set; }

        [DisplayName("Slaap")]
        public int Sleep { get; set; }

        [DisplayName("Verveling")]
        public int Boredom { get; set; }

        [DisplayName("Honger")]
        public int Hunger { get; set; }

        [DisplayName("Leven")]
        public int Health { get; set; }

        [DisplayName("Is levend")]
        public bool IsAlive { get; set; }

        [DisplayName("Leeftijd")]
        public int Age { get; set; }

        [DisplayName("Geboortedatum")]
        public DateTime CreationDate { get; set; }

        [DisplayName("Wachttijd")]
        public DateTime CooldownTill { get; set; }
    }
}