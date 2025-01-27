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
    public class BiographyRepository: GenericRepository<Biography>, IBiographyRepository
    {
        public BiographyRepository(MovieManagementDbContext context) : base(context)
        {

        }
    }
}
