using Microsoft.EntityFrameworkCore;
using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Data
{
    public class TeamManager : INew<Team>
    {
        readonly NewsContextDb _NewsContextDb;
        public TeamManager(NewsContextDb NewsContextDb)
        {
            _NewsContextDb = NewsContextDb;
        }
        public Task<int> Create(Team entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Edit(Team OldEntity, Team NewEntity)
        {
            throw new NotImplementedException();
        }

        public Task<Team> Get(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Team>> GetAll()
        {
           return await _NewsContextDb.Teams.ToListAsync();
        }

        public Task<int> Remove(Team entity)
        {
            throw new NotImplementedException();
        }
    }
}
