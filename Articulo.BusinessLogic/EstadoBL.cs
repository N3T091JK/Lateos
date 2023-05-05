using Lateos.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lateos.DataAccess.Migrations;
using Lateos.Entities;

namespace Articulo.BusinessLogic
{
    public class EstadoBL
    {
        private static EstadoBL _instance;
        public static EstadoBL Instance { get { return _instance; } }




        public List<Estado> SellectAll()
        {
            List<Estado> result;
            try
            {
                result = EstadoBL.Instance.SellectAll();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return result;
        }

        public bool Insert(Estado entity)
        {
            bool result = false;
            try
            {
                result = EstadoDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }

        public bool Update(Estado entity)
        {
            bool result = false;
            try
            {
                result = EstadoDAL.Instance.Update(entity);
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
                result = EstadoBL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }




    }


}
