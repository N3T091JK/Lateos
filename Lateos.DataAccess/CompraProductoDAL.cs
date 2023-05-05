using Lateos.Entities;
using Lateos.DataAccess.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Lateos.DataAccess
{
    public class CompraProductoDAL
    {
        //-------------------------------------------
        private static CompraProductoDAL _instance;

        public static CompraProductoDAL Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new CompraProductoDAL();
                }
                return _instance;
            }
        }
        //------------------------------------------------


        public List<CompraProducto> SellectAll()
        {
            List<CompraProducto> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.compraProductos.Include(x => x.MarcaProducto).ToList();
            }
            return result;
        }
        //--------------------------------------
        
        public CompraProducto SellectById(int id)
        {
            CompraProducto result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.compraProductos
                    .FirstOrDefault(x => x.IdCompraProducto == id);
            }
            return result;
        }
        
        //-----------------------------------------------------------------

        public List<DetalleCompra> SellecProductotById(int id)
        {
            List<DetalleCompra> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.detalleCompras.Where(x => x.IdCompraProducto.Equals(id)).ToList();
            }

            return result;


        }

        public bool Insert(CompraProducto entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.compraProductos.FirstOrDefault(x => x.MarcaProducto.Equals(entity.MarcaProducto));
                if (query == null)
                {
                    _context.compraProductos.Add(entity);
                    result = _context.SaveChanges() > 0;
                }
                return result;
            }
        }

        public bool Update(CompraProducto entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.compraProductos.FirstOrDefault(x => x.MarcaProducto.Equals(entity.MarcaProducto));
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
