using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Services
{
    public class SearchEmail
    {
        private readonly NewsContextDb _contextDb;

        public SearchEmail(NewsContextDb contextDb)
        {
            _contextDb = contextDb;
        }
        // SearchEmail
        public  bool SearchEmailORPassword(string Email)
        {
            var user=  _contextDb.Users.SingleOrDefault(em=>em.Email==Email);
            return (user == null) ? false : true;
        }

    }
}
