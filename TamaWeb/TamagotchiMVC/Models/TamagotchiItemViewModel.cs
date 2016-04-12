using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TamagotchiMVC.Models
{
    public class TamagotchiItemViewModel
    {
        public TamagotchiItemViewModel(TamagotchiServiceClient.TamagotchiItemDTO tamagotchiItem)
        {
            Name = tamagotchiItem.Name;
            ID = tamagotchiItem.ID;

            if (!String.IsNullOrEmpty(Name) && Char.IsLetter(Name[0]))
            {
                char tempChar = Char.ToLower(Name[0]);
                int tempInt = (int)tempChar;
                
                if(tempInt >= 97 && tempInt <= 104)
                {
                    ImagePath = "tama1.png";
                }
                else if (tempInt >= 105 && tempInt <= 112)
                {
                    ImagePath = "tama2.PNG";
                }
                else
                {
                    ImagePath = "tama3.PNG";
                }
            }
            else
            {
                ImagePath = "tama3.PNG";
            }
        }

        [DisplayName("Naam")]
        public String Name { get; set; }

        public int ID { get; set; }

        public String Status { get; set; }

        public String ImagePath { get; set; }
    }
}