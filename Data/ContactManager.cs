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

        public async Task<IEnumerable<ContactUs>> GetAll()
        {
            return await _context.ContactUs.ToListAsync();
        }
    }
}
