using Lateos.DataAccess;
using Lateos.DataAccess.AppContext;
using Lateos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulo.BusinessLogic
{
    public class DetalleCompraBL
    {
        private static DetalleCompraBL _instance;
        public static DetalleCompraBL Instance { get { return _instance; } }


        public List<DetalleCompra> SelectAll()
        {
            List<DetalleCompra> result = null;
            try
            {
                result = DetalleCompraBL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }


        public bool Insert(DetalleCompra entity)
        {
            bool result = false;
            try
            {
                result = DetalleCompraDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }

        public bool Update(DetalleCompra entity)
        {
            bool result = false;
            try
            {
                result = DetalleCompraDAL.Instance.Update(entity);
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
                result = DetalleCompraBL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }

    }
}
