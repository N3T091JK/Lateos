using Lateos.DataAccess;
using Lateos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulo.BusinessLogic
{
    public class RegistroBL
    {
        private static RegistroBL _instance;
        public static RegistroBL Instance { get { return _instance; } }


        public List<Registro> SelectAll()
        {
            List<Registro> result = null;
            try
            {
                result = RegistroBL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }


        public bool Insert(Registro entity)
        {
            bool result = false;
            try
            {
                result = RegistroDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }

        public bool Update(Registro entity)
        {
            bool result = false;
            try
            {
                result = RegistroDAL.Instance.Update(entity);
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
                result = RegistroBL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }
    }
}
