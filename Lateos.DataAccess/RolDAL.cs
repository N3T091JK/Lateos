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
    public class RolDAL
    {
        //--Instancia
        private static RolDAL _instance;

        public static RolDAL Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new RolDAL();
                }
                return _instance;
            }
        }


        //-----------------------------------------------------




        public Rol SellectById(int id)
        {
            Rol result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.Rols
                    .FirstOrDefault(x => x.IdRol == id);
            }

            return result;


        }


        //----------------------------------------------------------------

        public List<Rol> SellecProductotById(int id)
        {
            List<Rol> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.Rols.Where(x => x.IdRol.Equals(id)).ToList();
            }
            return result;
        }


        //---------------------------------------------------------------------
        public bool Insert(Rol entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.Rols.FirstOrDefault(x => x.Roles.Equals(entity.Roles));
                if (query == null)
                {
                    _context.Rols.Add(entity);
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }
        }

        //------------------------------------------------------------------------------
        public bool Update(Rol entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {

                var query = _context.Rols.FirstOrDefault(x => x.Roles.Equals(entity.Roles));


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
