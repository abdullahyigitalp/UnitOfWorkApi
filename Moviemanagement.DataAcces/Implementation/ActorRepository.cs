using Microsoft.EntityFrameworkCore;
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
    public class ActorRepository:GenericRepository<Actor>,IActorRepository
    {
        public ActorRepository(MovieManagementDbContext context):base(context)
        {

            
        }

        public IEnumerable<Actor> GetActorsByMovieId()
        {
            var actorswithmovies = _context.Actors.Include(u=>u.Movies).ToList();
            return actorswithmovies;
        }
    }
}
