using Business;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AlimentosServices : GenericServices<Alimento>
    {

        public AlimentosServices(GenericRepository<Alimento> repository): base(repository) { 
        }
    }
}
