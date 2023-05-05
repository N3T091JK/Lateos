using Lateos.Entities;
using Lateos.DataAccess.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Lateos.DataAccess.AppContext
{

    public class CategoriaDAL
    {

        //--Instancia
        private static CategoriaDAL _instance;

        public static CategoriaDAL Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new CategoriaDAL();
                }
                return _instance;
            }
        }

        //-------------------------------------------------------
        public List<Category> SellectAll()
        {
            List<Category> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.categorys.Include(x => x.Estado).ToList();
            }

            return result;


        }

//-----------------------------------------------------




        public Category SellectById(int id)
        {
            Category result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.categorys
                    .FirstOrDefault(x => x.IdCategoria == id);
            }

            return result;


        }

//----------------------------------------------------------------

        public List<Producto> SellecProductotById(int id)
        {
            List<Producto> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.productos.Where(x => x.IdCategoria.Equals(id)).ToList();
            }

            return result;


        }

//---------------------------------------------------------------------
        public bool Insert(Category entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.categorys.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));
                if (query == null)
                {
                    _context.categorys.Add(entity);
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }
        }

//------------------------------------------------------------------------------
        public bool Update(Category entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {

                var query = _context.categorys.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));


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



