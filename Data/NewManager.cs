using Microsoft.EntityFrameworkCore;
using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Data
{
    public class NewManager : INewsByID<New>
    {
        readonly NewsContextDb _context;

        public NewManager(NewsContextDb context)
        {
            _context = context;
        }

        public async Task<IEnumerable<New>> GetAll(int Id)
        {
            return await _context.News.Where(x => x.CategoryId == Id).OrderByDescending(x=>x.CategoryId).ToListAsync();
        }
    }
}
