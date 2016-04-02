using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamaWeb.Models
{
    public interface IRepository<T> : IDisposable
    {
        void Add(T item);                
        Task SaveChangesAsync();
        void SaveChanges();
        T Find(int id);
        IEnumerable<T> GetAllItems();
        IQueryable<T> AsQueryable();
    }
}