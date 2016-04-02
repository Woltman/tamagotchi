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
        }

        [DisplayName("Naam")]
        public String Name { get; set; }

        public int ID { get; set; }
        
        public String Status { get; set; }
    }
}