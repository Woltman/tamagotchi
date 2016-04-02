using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamaWeb.Models
{
    public class TamagotchiRepository : IRepository<Tamagotchi>
    {
        private readonly TamagotchiContext _database;

        public TamagotchiRepository(TamagotchiContext databaseContext)
        {
            _database = databaseContext;
        }

        public void Add(Tamagotchi item)
        {
            _database.Tamagotchis.Add(item);
        }

        public IEnumerable<Tamagotchi> GetAllItems()
        {
            return _database.Tamagotchis;
        }

        public void SaveChanges()
        {
            _database.ChangeTracker.DetectChanges();
            _database.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _database.SaveChangesAsync();
        }

        public IQueryable<Tamagotchi> AsQueryable()
        {
            return _database.Tamagotchis.AsQueryable();
        }

        public void Dispose()
        {
            _database.Dispose();
        }

        public Tamagotchi Find(int id)
        {
            return _database.Tamagotchis.Find(id);
        }
    }
}