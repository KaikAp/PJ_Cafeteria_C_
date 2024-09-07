using Business;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class VariacaoServices : GenericServices<Variacao>
    {
        public VariacaoServices(GenericRepository<Variacao> repository): base(repository) { }   
    }
}
