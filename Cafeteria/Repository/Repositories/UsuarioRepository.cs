using Business;
using Repository.Entity_framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    internal class UsuarioRepository
    {
        private Context _context;
        public UsuarioRepository(Context context)
        {
            this._context = context;

        }



        public virtual List<Usuario> GetAll()
        {
            return _context.Usuarios.OrderBy(t => t.Nome).ToList();
        }

        public virtual Usuario GetById(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public virtual void Delete(int id)
        {
            Usuario user = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(user);
        }

        public virtual void Delete(Usuario user)
        {
            _context.Remove(user);
        }

        public virtual void Update(Usuario user)
        {
            _context.Entry(user);
        }
    }
}

