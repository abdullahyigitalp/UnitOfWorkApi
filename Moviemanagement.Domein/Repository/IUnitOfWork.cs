using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviemanagement.Domein.Repository
{
    public interface IUnitOfWork:IDisposable
    {
        IActorRepository Actor { get; }
        IBiographyRepository Biography { get; }
        IGenreRepository Genre { get; }
        IMovieRepository Movie { get; }
        int Save(); 
    }
}
