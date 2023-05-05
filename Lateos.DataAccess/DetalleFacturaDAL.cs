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
    public class DetalleFacturaDAL
    {
        //------------------------------------
        private static DetalleFacturaDAL _instance;

        public static DetalleFacturaDAL Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new DetalleFacturaDAL();
                }
                return _instance;
            }
        }
        //------------------------------------------
        /*
        public List<DetalleFactura> SellectAll()
        {
            List<DetalleFactura> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.detalleFacturas.Include(x => x.Factura).ToList();
            }

            return result;


        }
        
        */
        //-----------------------------------------------------



        public DetalleFactura SellectById(int id)
        {
            DetalleFactura result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.detalleFacturas
                    .FirstOrDefault(x => x.IdDetalleFactura == id);
            }
            return result;
        }

        //--------------------------------------------------------

        public List<DetalleFactura> SellecProductotById(int id)
        {
            List<DetalleFactura> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.detalleFacturas.Where(x => x.IdProducto.Equals(id)).ToList();
            }
            return result;
        }
        //_--------------------------------------------------------
        public bool Insert(DetalleFactura entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.detalleFacturas.FirstOrDefault(x => x.Productos.Equals(entity.Productos));
                if (query == null)
                {
                    _context.detalleFacturas.Add(entity);
                    result = _context.SaveChanges() > 0;
                }
                return result;
            }
        }
        //---------------------------------------------------------------

        public bool Update(DetalleFactura entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {

                var query = _context.detalleFacturas.FirstOrDefault(x => x.Productos.Equals(entity.Productos));
                if (query == null)
                {
                    _context.Entry(entity).State = EntityState.Modified;
                    result = _context.SaveChanges() > 0;
                }
                return result;
            }
        }




    }
}
