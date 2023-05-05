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
    public class RegistroDAL
    {

        //--Instancia
        private static RegistroDAL _instance;

        public static RegistroDAL Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new RegistroDAL();
                }
                return _instance;
            }
        }

        //-------------------------------------------------------





        public Registro SellectById(int id)
        {
            Registro result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.Registros
                    .FirstOrDefault(x => x.IdRegistro == id);
            }

            return result;


        }

        //---------------------------------------------------------------------
        public bool Insert(Registro entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.Registros.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));
                if (query == null)
                {
                    _context.Registros.Add(entity);
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }
        }

        public bool Update(Registro entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {

                var query = _context.Registros.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));


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
