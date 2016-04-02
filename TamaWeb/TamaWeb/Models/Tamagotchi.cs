using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Tama.Contract;

namespace TamaWeb.Models
{
    
    public class Tamagotchi
    {
        private int _hunger;
        private int _sleep;
        private int _boredom;
        private int _health;



        public Tamagotchi(String name)
        {
            Name = name;
            Sleep = 0;
            Boredom = 0;
            Hunger = 0;
            Health = 0;
            IsAlive = true;
            CreationDate = DateTime.UtcNow;
            Age = 0;
            CooldownTill = DateTime.UtcNow;
        }

        protected Tamagotchi(){}

        public int ID { get; set; }

        public string Name { get; set; }

        public int Hunger
        {
            get
            {
                return _hunger;
            }
            set
            {
                if(value > 100)
                {
                    _hunger = 100;
                }
                else if(value < 0)
                {
                    _hunger = 0;
                }
                else
                {
                    _hunger = value;
                }
            }               
        }

        public int Sleep
        {
            get
            {
                return _sleep;
            }
            set
            {
                if (value > 100)
                {
                    _sleep = 100;
                }
                else if (value < 0)
                {
                    _sleep = 0;
                }
                else
                {
                    _sleep = value;
                }
            }
        }

        public int Boredom
        {
            get
            {
                return _boredom;
            }
            set
            {
                if (value > 100)
                {
                    _boredom = 100;
                }
                else if (value < 0)
                {
                    _boredom = 0;
                }
                else
                {
                    _boredom = value;
                }
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value > 100)
                {
                    _health = 100;
                }
                else if (value < 0)
                {
                    _health = 0;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public int Age { get; set; }

        public DateTime CreationDate { get; set; }

        public bool IsAlive { get; set; }

        public DateTime CooldownTill { get; set; }

        public int GetTicksSinceLastVisit(IGameClock clock)
        {
            //return clock.getTicks(LastVisit, CreationDate);
            throw new NotImplementedException();
        }

        internal TamagotchiItemDTO ToItem()
        {
            return new TamagotchiItemDTO()
            {
                ID = this.ID,
                Name = Name,
                
            };
        }

        public TamagotchiDTO ToDTO()
        {
            var tamagotchi = new TamagotchiDTO()
            {
                ID = this.ID,
                Name = this.Name,
                Boredom = this.Boredom,
                CreationDate = this.CreationDate,
                Hunger = this.Hunger,
                Sleep = this.Sleep,
                Health = this.Health,
                IsAlive = this.IsAlive,
                Age = this.Age,
                CooldownTill = this.CooldownTill,                
            };

            return tamagotchi;
        }

        public void Eat()
        {
            if (IsAlive && IsLater(DateTime.UtcNow))
            {
                //Hunger = 0;
                Hunger = 0;
                CooldownTill = DateTime.UtcNow.AddSeconds(30);
            }
        }

        public void Rest()
        {
            if (IsAlive && IsLater(DateTime.UtcNow))
            {
                Sleep = 0;
                CooldownTill = DateTime.UtcNow.AddHours(2);
            }
        }

        public void Play()
        {
            if (IsAlive && IsLater(DateTime.UtcNow))
            {
                Boredom -= 10;
                CooldownTill = DateTime.UtcNow.AddSeconds(30);
            }
        }

        public void Workout()
        {
            if (IsAlive && IsLater(DateTime.UtcNow))
            {
                Health -= 5;
                CooldownTill = DateTime.UtcNow.AddSeconds(60);
            }
        }

        public void Hug()
        {
            if (IsAlive && IsLater(DateTime.UtcNow))
            {
                Health -= 10;
                CooldownTill = DateTime.UtcNow.AddSeconds(60);
            }
        }

        public bool IsLater(DateTime date)
        {
            int number = date.CompareTo(CooldownTill);

            if(number == -1)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"{ID}:{Name}: sleep:{Sleep} boredom:{Boredom} hunger:{Hunger} Health:{Health}";
        }
    }
}