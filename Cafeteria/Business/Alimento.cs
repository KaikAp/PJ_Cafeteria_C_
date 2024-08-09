using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Alimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public float Valor { get; set; }
        public Categoria Categoria { get; set; }

        public List<Variacao> Variacaos { get; set; }
    }
}
