using Microsoft.EntityFrameworkCore;
using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Data
{
    public class CommentManager : INew<Comment>
    {
        readonly NewsContextDb _context;

        public CommentManager(NewsContextDb context)
        {
            _context = context;
        }
        public async Task<int> Create(Comment comment)
        {
           await _context.Comments.AddAsync(comment);
            return await _context.SaveChangesAsync();
        }

        public Task<int> Edit(Comment OldEntity, Comment NewEntity)
        {
            throw new NotImplementedException();
        }

        public async Task<Comment> Get(int ID)
        {
            return await _context.Comments.FindAsync(ID); 
        }

        public async Task<IEnumerable<Comment>> GetAll()
        {
            
            return await _context.Comments.ToListAsync();
        }

        public async Task<int> Delete(Comment comment)
        {
            _context.Comments.Remove(comment);
            return await _context.SaveChangesAsync();
        }
    }
}
