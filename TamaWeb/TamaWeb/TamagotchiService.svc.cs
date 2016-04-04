using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Tama.Contract;

using TamaWeb.Models;
using TamaWeb.Spelregels;

namespace TamaWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class TamagotchiService : ITamagotchiService, IDisposable
    {            
        private readonly IRepository<Tamagotchi> repo;
        private readonly SpelregelEngine _spelregelEngine;

        //public static Tamagotchi thom = new Tamagotchi("Thom") {Sleep = 50, Health = 10, Boredom = 20, Hunger = 100};

        //public static List<Tamagotchi> allTamagotchi =  new List<Tamagotchi>();

        public TamagotchiService(IRepository<Tamagotchi> tamagotchiRepo, SpelregelEngine spelregelEngine)
        {          
            repo = tamagotchiRepo;
            _spelregelEngine = spelregelEngine;
        }

        public IEnumerable<TamagotchiItemDTO> GetAll()
        {
            return repo.GetAllItems()
                .Select(t => t.ToItem())
                .ToList();    
        }     

        public TamagotchiDTO AddTamagotchi(String name)
        {
            var tamagotchi = new Tamagotchi(name);
            repo.Add(tamagotchi);
            repo.SaveChanges();

            return tamagotchi.ToDTO();
        }

        public TamagotchiDTO GetTamagotchiDTO(int id)
        {
            var tamagotchi = repo.Find(id);

            if(tamagotchi == null)
            {
                return null;
            }

            ExecuteSpelregels(tamagotchi);
                      

            return tamagotchi.ToDTO();
        }

        public TamagotchiDTO Eat(int id)
        {
            var tamagotchi = repo.Find(id);
            ExecuteSpelregels(tamagotchi);
            ExecuteSpelregelActions(tamagotchi);
            tamagotchi.Eat();
            repo.SaveChanges();
            
            return tamagotchi.ToDTO();
        }

        public TamagotchiDTO Hug(int id)
        {
            var tamagotchi = repo.Find(id);
            ExecuteSpelregels(tamagotchi);
            ExecuteSpelregelActions(tamagotchi);
            tamagotchi.Hug();
            repo.SaveChanges();

            return tamagotchi.ToDTO();
        }

        public TamagotchiDTO Play(int id)
        {
            var tamagotchi = repo.Find(id);
            ExecuteSpelregels(tamagotchi);
            ExecuteSpelregelActions(tamagotchi);
            tamagotchi.Play();
            repo.SaveChanges();

            return tamagotchi.ToDTO();
        }

        public TamagotchiDTO Rest(int id)
        {
            var tamagotchi = repo.Find(id);
            ExecuteSpelregels(tamagotchi);
            ExecuteSpelregelActions(tamagotchi);
            tamagotchi.Rest();
            repo.SaveChanges();

            return tamagotchi.ToDTO();
        }

        public TamagotchiDTO Workout(int id)
        {
            var tamagotchi = repo.Find(id);
            ExecuteSpelregels(tamagotchi);
            ExecuteSpelregelActions(tamagotchi);
            tamagotchi.Workout();
            repo.SaveChanges();

            return tamagotchi.ToDTO();
        }

        private void ExecuteSpelregels(Tamagotchi tamagotchi)
        {           
            _spelregelEngine.ExecuteSpelRegels(tamagotchi);

            repo.SaveChanges();
        }
        private void ExecuteSpelregelActions(Tamagotchi tamagotchi)
        {
            _spelregelEngine.ExecuteSpelregelActions(tamagotchi);

            repo.SaveChanges();
        }

        private Tamagotchi GetTamagotchi(int ID)
        {
            //return allTamagotchi.Where(r => r.ID == ID).First();
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
