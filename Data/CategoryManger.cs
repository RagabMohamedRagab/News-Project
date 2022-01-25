using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_n9ws.Models;

namespace Project_n9ws.Data
{
    public class CategoryManger : INew<Category>
    {
        readonly NewsContext _newsContext;
        public CategoryManger(NewsContext newsContext)
        {
            _newsContext = newsContext;
        }

        public async Task<int> Create(Category category)
        {
           await _newsContext.Categories.AddAsync(category);
            return await _newsContext.SaveChangesAsync();
        }

        public async Task<int> Edit(Category OldEntity, Category NewEntity)
        {
            try
            {
                if (OldEntity.Id == NewEntity.Id)
                {
                    OldEntity.Name = NewEntity.Name;
                    OldEntity.Description = NewEntity.Description;
                    return await _newsContext.SaveChangesAsync();
                }
                throw new Exception();
            }
            catch (Exception)
            {

            }
            return 0;
        }
        public async Task<Category> Get(int ID)
        {
            return await _newsContext.Categories.FindAsync(ID);
        }
        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _newsContext.Categories.ToListAsync();
        }

        public async Task<int> Remove(Category category)
        {
            _newsContext.Categories.Remove(category);
            return await _newsContext.SaveChangesAsync();
        }
    }
}
