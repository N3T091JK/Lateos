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
    public class LogDAL
    {
        //--Instancia
        private static LogDAL _instance;

        public static LogDAL Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new LogDAL();
                }
                return _instance;
            }
        }

        //-------------------------------------------------------
        /*
        public List<Log> SellectAll()
        {
            List<Log> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.Logs.Include(x =>x.IdLog).ToList();
            }

            return result;


        }
        */
        //-----------------------------------------------------



        public bool Insert(Log entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.Logs.FirstOrDefault(x => x.Descripcion.Equals(entity.Descripcion));
                if (query == null)
                {
                    _context.Logs.Add(entity);
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }
        }

        public Log SellectById(int id)
        {
            Log result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.Logs
                    .FirstOrDefault(x => x.logId == id);
            }

            return result;


        }

        //----------------------------------------------------------------
        public List<Log> SellectAll()
        {
            List<Log> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.Logs.ToList();
            }

            return result;


        }



        //---------------------------------------------------------------------

       // ------------------------------------------------------------------------------
        public bool Update(Log entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {

                var query = _context.Logs.FirstOrDefault(x => x.Descripcion.Equals(entity.Descripcion));


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
