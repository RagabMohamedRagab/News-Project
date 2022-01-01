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
        readonly NewsContext newsContext;

        public CategoryManger(NewsContext _newsContext)
        {
            newsContext = _newsContext;
        }

        public async Task<int> Create(Category entity)
        {
            await newsContext.Categories.AddAsync(entity);
           return await newsContext.SaveChangesAsync();
        }

        public async Task<int> Edit(Category OldEntity, Category NewEntity)
        {
            OldEntity.Id = NewEntity.Id;
            OldEntity.Name = NewEntity.Name;
            OldEntity.Description = NewEntity.Description;
            return await newsContext.SaveChangesAsync();
        }

        public async Task<Category> Get(int ID)
        {
            return await newsContext.Categories.FindAsync(ID);
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await newsContext.Categories.ToListAsync();
        }

        public async Task<int> Remove(Category entity)
        {
            newsContext.Categories.Remove(entity);
            return await newsContext.SaveChangesAsync();
        }
    }
}
