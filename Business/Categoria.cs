﻿namespace Business
{
    public class Categoria
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Imagem {get; set;}
        public virtual List<Alimento> alimentos {get; set;}



    }
}
