using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Variacao
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Imagem { get; set; }
        public Alimento Alimento { get; set; }
    }
}
