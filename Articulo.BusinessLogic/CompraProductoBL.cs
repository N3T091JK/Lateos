using Lateos.DataAccess;
using Lateos.DataAccess.AppContext;
using Lateos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace Articulo.BusinessLogic
{
    public class CompraProductoBL
    {
        private static CompraProductoBL _instance;
        public static CompraProductoBL Instance { get { return _instance; } }


        public List<CompraProducto> SelectAll()
        {
            List<CompraProducto> result = null;
            try
            {
                result = CompraProductoBL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }


        public bool Insert(CompraProducto entity)
        {
            bool result = false;
            try
            {
                result = CompraProductoDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }

        public bool Update(CompraProducto entity)
        {
            bool result = false;
            try
            {
                result = CompraProductoDAL.Instance.Update(entity);
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
                result = CompraProductoBL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }
    }
}
