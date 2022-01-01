using Microsoft.EntityFrameworkCore;
using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Data
{
    public class ContactManager : INews<ContactUs>
    {
        readonly NewsContext _context;

        public ContactManager(NewsContext context)
        {
            _context = context;
        }

        public async Task<int> Create(ContactUs contact)
        {
            await _context.ContactUs.AddAsync(contact);
            return await _context.SaveChangesAsync();
          }

        public Task<int> Edit(ContactUs OldEntity, ContactUs NewEntity)
        {
            throw new NotImplementedException();
        }

        public async Task<ContactUs> Get(int ID)
        {
            return await _context.ContactUs.FindAsync(ID);
        }

        public async Task<IEnumerable<ContactUs>> GetAll()
        {
            return await _context.ContactUs.ToListAsync();
        }

        public Task<int> Remove(ContactUs entity)
        {
            throw new NotImplementedException();
        }
    }
}
