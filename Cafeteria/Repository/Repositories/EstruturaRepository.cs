using Business;
using Repository.Entity_framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class EstruturaRepository : GenericRepository<Estrutura>
    {
        public EstruturaRepository(Context context): base(context){ 


        }

    }
}
