using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TamagotchiMVC.Models
{
    public class AddTamagotchi
    {
        [Required]
        public string Name { get; set; }
    }
}