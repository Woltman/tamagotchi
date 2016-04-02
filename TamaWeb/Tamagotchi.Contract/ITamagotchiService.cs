using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Tama.Contract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITamagotchiService
    {
        [OperationContract]
        TamagotchiDTO GetTamagotchiDTO(int id);

        [OperationContract]
        TamagotchiDTO Rest(int id);

        [OperationContract]
        TamagotchiDTO Eat(int id);

        [OperationContract]
        TamagotchiDTO Play(int id);

        [OperationContract]
        TamagotchiDTO Workout(int id);

        [OperationContract]
        TamagotchiDTO Hug(int id);

        [OperationContract]
        TamagotchiDTO AddTamagotchi(String name);

        [OperationContract]
        IEnumerable<TamagotchiItemDTO> GetAll();
    }
}
