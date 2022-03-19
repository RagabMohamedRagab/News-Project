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
        readonly NewsContextDb _NewsContextDb;
        public CategoryManger(NewsContextDb NewsContextDb)
        {
            _NewsContextDb = NewsContextDb;
        }

        public async Task<int> Create(Category category)
        {
           await _NewsContextDb.Categories.AddAsync(category);
            return await _NewsContextDb.SaveChangesAsync();
        }

        public async Task<int> Edit(Category OldEntity, Category NewEntity)
        {
            try
            {
                if (OldEntity.Id == NewEntity.Id)
                {
                    OldEntity.Name = NewEntity.Name;
                    OldEntity.Description = NewEntity.Description;
                    return await _NewsContextDb.SaveChangesAsync();
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
            return await _NewsContextDb.Categories.FindAsync(ID);
        }
        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _NewsContextDb.Categories.ToListAsync();
        }

        public async Task<int> Delete(Category category)
        {
            _NewsContextDb.Categories.Remove(category);
            return await _NewsContextDb.SaveChangesAsync();
        }
    }
}
