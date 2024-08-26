using Business;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EstruturaServices : GenericServices<Estrutura>
    {
        public EstruturaServices(GenericRepository<Estrutura> repository) : base(repository) { }
    }
}
