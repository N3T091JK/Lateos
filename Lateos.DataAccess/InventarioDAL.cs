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
    public class InventarioDAL
    {
        private static InventarioDAL _instance;

        public static InventarioDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InventarioDAL();
                }
                return _instance;

            }

        }
        
        public bool Insert(Inventario entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.inventarios
                    .FirstOrDefault(x => x.IdInventario.Equals(entity.IdInventario)
                    );
                if (query == null)
                {
                    _context.inventarios.Add(entity);
                    result = _context.SaveChanges() > 0;


                }

                return result;

            }

        }
        

        public List<Inventario> SellectAll()
        {
            List<Inventario> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.inventarios.ToList();
            }

            return result;


        }
        public List<Inventario> SellecProductotById(int id)
        {
            List<Inventario> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.inventarios.Where(x => x.IdInventario.Equals(id)).ToList();
            }

            return result;


        }

        public Inventario SellectById(int id)
        {
            Inventario result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.inventarios
                    .FirstOrDefault(x => x.IdInventario == id);
            }

            return result;


        }

        public bool Update(Inventario entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {

                var query = _context.inventarios.FirstOrDefault(x => x.Stock.Equals(entity.Stock));


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
