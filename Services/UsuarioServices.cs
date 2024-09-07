using Business;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UsuarioServices : GenericServices<Usuario>
    {
        public UsuarioServices(GenericRepository<Usuario> repository) : base(repository) { }
    }
}
