using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Data
{
    public interface INewsByID<T> where T:class
    {
        /// GetAll by ID
        Task<IEnumerable<T>> GetAll(int Id);
    }
}
