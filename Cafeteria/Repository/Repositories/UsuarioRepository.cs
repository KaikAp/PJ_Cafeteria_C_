using Business;
using Repository.Entity_framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    internal class UsuarioRepository : GenericRepository<Usuario>
    {
        public UsuarioRepository(Context context) : base(context) { 
        
        
        }


    }
}

