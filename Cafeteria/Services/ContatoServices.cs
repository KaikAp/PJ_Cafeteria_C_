using Business;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ContatoServices : GenericServices<Contato>
    {

        public ContatoServices(GenericRepository<Contato> repository) : base(repository) { }
    }
}
