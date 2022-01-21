using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Data
{
    public interface INews<T> where T:class
    {
        /// GetAll
        Task<IEnumerable<T>> GetAll();
        
    }
}
