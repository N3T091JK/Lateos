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
    public class DetalleCompraDAL
    {
        private static DetalleCompraDAL _instance;

        public static DetalleCompraDAL Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new DetalleCompraDAL();
                }
                return _instance;
            }
        }
        //-------------------------------------------------
        /*
        public List<DetalleCompra> SellectAll()
        {
            List<DetalleCompra> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.detalleCompras.Include(x => x.IdComprar).ToList();
            }
            return result;
        }
        */
        public DetalleCompra SellectById(int id)
        {
            DetalleCompra result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.detalleCompras
                    .FirstOrDefault(x => x.IdDetalleCompra == id);
            }
            return result;
        }
        //-----------------------------------------------------
        public List<DetalleCompra> SellecProductotById(int id)
        {
            List<DetalleCompra> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.detalleCompras.Where(x => x.IdCompraProducto.Equals(id)).ToList();
            }
            return result;
        }

        //-------------------------------------------------------------------
        public bool Insert(DetalleCompra entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.detalleCompras.FirstOrDefault(x => x.CompraProductos.Equals(entity.CompraProductos));
                if (query == null)
                {
                    _context.detalleCompras.Add(entity);
                    result = _context.SaveChanges() > 0;
                }
                return result;
            }
        }
        //---------------------------------------------------------------
        public bool Update(DetalleCompra entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.detalleCompras.FirstOrDefault(x => x.Descuento.Equals(entity.Descuento));
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
