using Microsoft.EntityFrameworkCore;
using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Data
{
    public class CountryManager : INew<Country>
    {
        private readonly NewsContextDb _contextDb;

        public CountryManager(NewsContextDb contextDb)
        {
            _contextDb = contextDb;
        }
        public Task<int> Create(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Edit(Country OldEntity, Country NewEntity)
        {
            throw new NotImplementedException();
        }

        public Task<Country> Get(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Country>> GetAll()
        {
            return await _contextDb.Countries.ToListAsync();

        }

        public Task<int> Delete(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
