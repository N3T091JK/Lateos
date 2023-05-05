
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
    public class EstadoDAL
    {

        private static EstadoDAL _instance;

        public static EstadoDAL Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new EstadoDAL();
                }
                return _instance;
            }
        }
        //-------------------------------------------------------
        
        public List<Estado> SellectAll()
        {
            List<Estado> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.estados.Include(x => x.IdEstado).ToList();
            }

            return result;


        }
        

        //-----------------------------------------------------




        public Estado SellectById(int id)
        {
            Estado result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.estados
                    .FirstOrDefault(x => x.IdEstado == id);
            }

            return result;


        }
        //------------------------------------------------------
        //----------------------------------------------------------------

        public List<Estado> SellecProductotById(int id)
        {
            List<Estado> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.estados.Where(x => x.IdEstado.Equals(id)).ToList();
            }

            return result;


        }

        //---------------------------------------------------------------------

        ////si el producto no existe
        public bool Insert(Estado entity)
        {
            bool  result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.estados.FirstOrDefault(x => x.IdEstado.Equals(entity.IdEstado));
              
            }
            return result;
        }


        //------------------------------------------------------------------------------
        public bool Update(Estado entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {

                var query = _context.estados.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));


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
