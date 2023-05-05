using Lateos.DataAccess.AppContext;
using Lateos.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lateos.DataAccess
{
    public class UsuarioDAL
    {
        //--Instancia
        private static UsuarioDAL _instance;

        public static UsuarioDAL Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new UsuarioDAL();
                }
                return _instance;
            }
        }


        //-----------------------------------------------------

        //-------------------------------------------------------
        public List<Usuario> SellectAll()
        {
            List<Usuario> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.usuarios.Include(x => x.Estados).ToList();
            }

            return result;


        }


        public Usuario SellectById(int id)
        {
            Usuario result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.usuarios
                    .FirstOrDefault(x => x.IdUsuario == id);
            }
            return result;
        }

        //----------------------------------------------------------------


        public bool Insert(Usuario entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.usuarios.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));
                if (query == null)
                {
                    _context.usuarios.Add(entity);
                    result = _context.SaveChanges() > 0;
                }
                return result;

            }
        }
        //------------------------------------------------------------------------------
        public bool Update(Usuario entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {

                var query = _context.usuarios.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));


                if (query == null)
                {
                    _context.Entry(entity).State = EntityState.Modified;
                    result = _context.SaveChanges() > 0;

                }

                return result;
            }
        }
        //--------------------------------------------------------------------


    }
}
