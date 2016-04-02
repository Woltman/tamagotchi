using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Tama.Contract
{
    [DataContract]
    public class TamagotchiDTO
    {
        public TamagotchiDTO()
        {

        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public int Sleep { get; set; }

        [DataMember]
        public int Boredom { get; set; }

        [DataMember]
        public int Hunger { get; set; }

        [DataMember]
        public int Health { get; set; }

        [DataMember]
        public bool IsAlive { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public DateTime CreationDate { get; set; }

        [DataMember]
        public DateTime CooldownTill { get; set; }

        public override string ToString()
        {
            return $"{ID}:{Name}: sleep:{Sleep} boredom:{Boredom} hunger:{Hunger} Health:{Health}";
        }
    }
}