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
    public  class FacturaDAL
    {

        //--Instancia
        private static FacturaDAL _instance;

        public static FacturaDAL Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new FacturaDAL();
                }
                return _instance;
            }
        }

        //-----------------------------------------------------
        public Facturas SellectById(int id)
        {
           Facturas result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.facturas
                    .FirstOrDefault(x => x.IdFactura == id);
            }
            return result;
        }
        //----------------------------------------------------------------
        public List<Facturas> SellecProductotById(int id)
        {
            List<Facturas> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.facturas.Where(x => x.IdUsuario.Equals(id)).ToList();
            }

            return result;


        }
        //---------------------------------------------------------------------
        public bool Insert(Facturas entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.facturas.FirstOrDefault(x => x.Descuento.Equals(entity.Descuento));
                if (query == null)
                {
                    _context.facturas.Add(entity);
                    result = _context.SaveChanges() > 0;
                }
                return result;

            }
        }

        //------------------------------------------------------------------------------

        public bool Update(Facturas entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {

                var query = _context.facturas.FirstOrDefault(x => x.Descuento.Equals(entity.Descuento));


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
