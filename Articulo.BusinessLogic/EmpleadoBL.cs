using Lateos.DataAccess;
using Lateos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulo.BusinessLogic
{
    public class EmpleadoBL
    {
        private static EmpleadoBL _instance;
        public static EmpleadoBL Instance { get { return _instance; } }


        public List<Empleado> SelectAll()
        {
            List<Empleado> result = null;
            try
            {
                result = EmpleadoBL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }


        public bool Insert(Empleado entity)
        {
            bool result = false;
            try
            {
                result = EmpleadoDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }

        public bool Update(Empleado entity)
        {
            bool result = false;
            try
            {
                result = EmpleadoDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                result = EmpleadoBL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }
    }
}
