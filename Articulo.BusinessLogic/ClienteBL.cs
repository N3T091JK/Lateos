using Lateos.DataAccess.AppContext;
using Lateos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Lateos.DataAccess;

namespace Articulo.BusinessLogic
{
    public class ClienteBL
    {
        private static ClienteBL _instance;
        public static ClienteBL Instance { get { return _instance; } }


        public List<Cliente> SellecALL()
        {
            List<Cliente> result;
            try
            {
                result = ClienteDAL.Instance.SellectAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Insert(Cliente entity)
        {
            bool result = false;
            try
            {
                result = ClienteDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }

        public bool Update(Cliente entity)
        {
            bool result = false;
            try
            {
                result = ClienteDAL.Instance.Update(entity);
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
                result = ClienteBL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }
    }
}
