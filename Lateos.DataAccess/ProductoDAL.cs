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
    public class ProductoDAL 
    {
        

        ////si el producto no existe
        public bool Insert(Producto entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.productos
                    .FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));

                if (query == null)
                {
                    _context.productos.Add(entity);
                    result = _context.SaveChanges() > 0;

                    _context.inventarios.Add(new Inventario { IdProduto = entity.IdProducto, Stock = 0 });
                    _context.SaveChanges();
                }
            }
            return result;
        }
        public List<Producto> SellectAll()
        {
            List<Producto> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.productos.ToList();
            }

            return result;


        }

        public Producto SellectById(int id)
        {
            Producto result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.productos
                    .FirstOrDefault(x => x.IdProducto == id);
            }

            return result;


        }

        public List<Producto> SellecProductotById(int id)
        {
            List<Producto> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.productos.Where(x => x.IdProducto.Equals(id)).ToList();
            }

            return result;


        }
        //------------------------------------------------------------------------------
        public bool Update(Producto entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {

                var query = _context.productos.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));


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
