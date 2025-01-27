using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviemanagement.Domein.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public List<Movie>? Movies { get; set; }//Bir aktörün birden fazla filmi olabilir.
        public Biography? Biography { get; set; }//Aktörün sadece bir tane biyografisi olabilir.

    }
}
