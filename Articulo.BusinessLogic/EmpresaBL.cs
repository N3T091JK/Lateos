using Lateos.DataAccess;
using Lateos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulo.BusinessLogic
{
    public class EmpresaBL
    {
        private static EmpresaBL _instance;
        public static EmpresaBL Instance { get { return _instance; } }


        public List<Empresa> SelectAll()
        {
            List<Empresa> result = null;
            try
            {
                result = EmpresaBL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }


        public bool Insert(Empresa entity)
        {
            bool result = false;
            try
            {
                result = EmpresaDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }

        public bool Update(Empresa entity)
        {
            bool result = false;
            try
            {
                result = EmpresaDAL.Instance.Update(entity);
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
                result = EmpresaBL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }
    }
}
