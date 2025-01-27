using Moviemanagement.DataAcces.Context;
using Moviemanagement.Domein.Entities;
using Moviemanagement.Domein.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviemanagement.DataAcces.Implementation
{
    public class GenreRepository:GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(MovieManagementDbContext context): base(context)
        {

        }
    }
}
