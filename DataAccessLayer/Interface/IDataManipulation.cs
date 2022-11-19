using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IDataManipulation<T> where T : class
    {
        IEnumerable<T> GetAll();
        T FindEntityById(int id);
        void Update(int id, T item);
        void Create(T item);
        void Delete();
        void Dispose();
        void Save();
    }

    public interface IDataManipulationAsync<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> FindEntityByIdAsync(int id);
        Task UpdateAsync(int id, T item);

        Task CreateAsync(T item);

        Task DeleteAsync(T item);

        Task DisposeAsync();
        Task SaveAsync();
    }
}
