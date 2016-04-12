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
            Status = status();
            ImagePath = imagePath();
            StatusImagePath = statusImagePath();
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

        [DisplayName("Status")]
        public String Status { get; set; }

        public String ImagePath { get; set; }

        public String StatusImagePath { get; set; }

        private String status()
        {
            if (!IsAlive)
            {
                return "Overleden";
            }
            else if (Hunger == 0 && Sleep == 0 && Boredom == 0 && Health == 0)
            {
                return "Gezond";
            }
            else if (Hunger > Sleep && Hunger > Boredom && Hunger > Health)
            {
                return "Hongerig";
            }
            else if (Sleep > Boredom && Sleep > Health)
            {
                return "Slapering";
            }
            else if (Boredom > Health)
            {
                return "Verveeld";
            }
            else
            {
                return "Ongezond";
            }
        }

        private String imagePath()
        {
            if (!String.IsNullOrEmpty(Name) && Char.IsLetter(Name[0]))
            {
                char tempChar = Char.ToLower(Name[0]);
                int tempInt = (int)tempChar;

                if (tempInt >= 97 && tempInt <= 104)
                {
                    return "tama1.png";
                }
                else if (tempInt >= 105 && tempInt <= 112)
                {
                    return "tama2.PNG";
                }
                else
                {
                    return "tama3.PNG";
                }
            }
            else
            {
                return "tama3.PNG";
            }
        }

        private String statusImagePath()
        {
            if (Status == "Overleden")
            {
                return "dead.png";
            }
            else if (Status == "Gezond")
            {
                return "healthy.PNG";
            }
            else if (Status == "Hongerig")
            {
                return "hunger.PNG";
            }
            else if (Status == "Slaperig")
            {
                return "sleep.PNG";
            }
            else if (Status == "Verveeld")
            {
                return "boredom.PNG";
            }
            else
            {
                return "unhealthy.PNG";
            }
        }
    }
}