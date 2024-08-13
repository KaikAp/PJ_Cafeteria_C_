using Business;
using Repository.Entity_framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CategoriaRepository
    {
        private Context _context;
        public CategoriaRepository(Context context) { 
        this._context = context;
        
        }



        public virtual List<Categoria> GetAll()
        {
           return _context.Categorias.OrderBy(t=>t.Nome).ToList();
        }

        public virtual Categoria GetById(int id)
        {
            return _context.Categorias.Find(id);
        }

        public virtual void Delete(int id)
        {
            Categoria categoria = _context.Categorias.Find(id);
            _context.Categorias.Remove(categoria);
        }

        public virtual void Delete(Categoria categoria)
        {
            _context.Remove(categoria);
        }

        public virtual void Update(Categoria categoria)
        {
            _context.Entry(categoria);
        }
    }
}
