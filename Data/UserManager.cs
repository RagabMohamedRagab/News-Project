using Microsoft.EntityFrameworkCore;
using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Data
{
    public class UserManager : INew<User>
    {
        private readonly NewsContextDb _contextDb;

        public UserManager(NewsContextDb contextDb)
        {
            _contextDb = contextDb;
        }

        public async Task<int> Create(User user)
        {
            await _contextDb.Users.AddAsync(user);
            return await _contextDb.SaveChangesAsync();
        }

        public Task<int> Edit(User OldEntity, User NewEntity)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _contextDb.Users.ToListAsync();
        }

        public Task<int> Remove(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
