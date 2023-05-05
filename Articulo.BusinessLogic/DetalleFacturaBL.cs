using Lateos.DataAccess;
using Lateos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulo.BusinessLogic
{
    public class DetalleFacturaBL
    {
        private static DetalleFacturaBL _instance;
        public static DetalleFacturaBL Instance { get { return _instance; } }


        public List<DetalleFactura> SelectAll()
        {
            List<DetalleFactura> result = null;
            try
            {
                result = DetalleFacturaBL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }


        public bool Insert(DetalleFactura entity)
        {
            bool result = false;
            try
            {
                result = DetalleFacturaDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }

        public bool Update(DetalleFactura entity)
        {
            bool result = false;
            try
            {
                result = DetalleFacturaDAL.Instance.Update(entity);
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
                result = DetalleFacturaBL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }
    }
}
