using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Data
{
  public interface INew<T> where T:class
    {
     
        // Add
        Task<int> Create(T entity);
        // remove 
        Task<int> Delete(T entity);
        // Update
        Task<int> Edit(T OldEntity, T NewEntity);
        Task<T> Get(int ID);
        /// GetAll
        Task<IEnumerable<T>> GetAll();
    }
}
