using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Moviemanagement.Domein.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;

        public int ActorId { get; set; }//Bir filmin birden fazla aktörü olabilir    
        public Actor? Actor { get; set; }//Bir filmde bir aktörden sadece bir tane olabilir.
        public List<Genre>? Genre { get; set; }//Bir filmin birden fazla türü olabilir.

        //Genre ve movie arasında many to many ilişki var.
        //Movie ve Actor arasında one to many ilişki var.
        //Actor ve Biography arasında one to one ilişki var.
        
    }
}
