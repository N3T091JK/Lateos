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
    public class EmpleadoDAL
    {
        //--Instancia
        private static EmpleadoDAL _instance;

        public static EmpleadoDAL Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new EmpleadoDAL();
                }
                return _instance;
            }
        }
        //-----------------------------------------------

        //-------------------------------------------------------
        /*
        public List<Empleado> SellectAll()
        {
            List<Empleado> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.empleados.Include(x => x.Empleado).ToList();
            }

            return result;


        }
        */

        //-----------------------------------------------------
        public Empleado SellectById(int id)
        {
            Empleado result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.empleados
                    .FirstOrDefault(x => x.IdEmpleado == id);
            }
            return result;
        }
        //-------------------------------------------------------------------

        public List<Empleado> SellecProductotById(int id)
        {
            List<Empleado> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.empleados.Where(x => x.IdEmpleado.Equals(id)).ToList();
            }
            return result;
        }

        //---------------------------------------------------------------------


        //---------------------------------------------------------------------
        public bool Insert(Empleado entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.empleados.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));
                if (query == null)
                {
                    _context.empleados.Add(entity);
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }
        }

        //---------------------------------------------------------------

        public bool Update(Empleado entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {

                var query = _context.empleados.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));


                if (query == null)
                {
                    _context.Entry(entity).State = EntityState.Modified;
                    result = _context.SaveChanges() > 0;

                }

                return result;
            }
        }

        //-----------------------------------------------------

    }
}
