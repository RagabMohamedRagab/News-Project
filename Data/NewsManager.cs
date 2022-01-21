using Microsoft.EntityFrameworkCore;
using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Data
{
    public class NewsManager : IAdmin<New>
    {
        readonly NewsContext _context;

        public NewsManager(NewsContext context)
        {
            _context = context;
        }

        public async Task<int> Create(New entity)
        {
             await _context.News.AddAsync(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Edit(New OldEntity, New NewEntity)
        {
            if (OldEntity.Id == NewEntity.Id)
            {
                OldEntity.Title = NewEntity.Title;
                OldEntity.Topic = NewEntity.Topic;
                OldEntity.Image = NewEntity.Image;
                OldEntity.Date = NewEntity.Date;
                OldEntity.CategoryId = NewEntity.CategoryId;
                return await _context.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<New> Get(int ID)
        {
            return await _context.News.FindAsync(ID);
        }

        public async Task<IEnumerable<New>> GetAll(int id)
        {
            IEnumerable<New> news = await _context.News.Where(Val => Val.CategoryId == id).ToListAsync();
            if (news != null)
            {
                return news;
            }
            return null;
        }

        public async Task<int> Remove(New entity)
        {
            _context.News.Remove(entity);
            return await _context.SaveChangesAsync();
            
        }
    }
}
