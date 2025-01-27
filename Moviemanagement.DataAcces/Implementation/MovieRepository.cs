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
    public class MovieRepository: GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieManagementDbContext context) : base(context)
        {

        }
    }
}
