using Microsoft.EntityFrameworkCore;
using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Data
{
    public class ContactManager : INew<ContactUs>
    {
        readonly NewsContextDb _context;

        public ContactManager(NewsContextDb context)
        {
            _context = context;
        }

        public Task<int> Create(ContactUs entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Edit(ContactUs OldEntity, ContactUs NewEntity)
        {
            throw new NotImplementedException();
        }

        public Task<ContactUs> Get(int ID)
        {
            throw new NotImplementedException();
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
