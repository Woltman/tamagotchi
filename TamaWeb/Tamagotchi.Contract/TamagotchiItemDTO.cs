using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tama.Contract
{
    [DataContract]
    public class TamagotchiItemDTO
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public String Name { get; set; }

        public override string ToString()
        {
            return $"{ID}:{Name}";
        }
    }
}
