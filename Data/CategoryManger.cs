using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_n9ws.Models;

namespace Project_n9ws.Data
{
    public class CategoryManger : INews<Category>
    {
        readonly NewsContext _newsContext;

        public CategoryManger(NewsContext newsContext)
        {
            _newsContext = newsContext;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _newsContext.Categories.ToListAsync();
        }
    }
}
