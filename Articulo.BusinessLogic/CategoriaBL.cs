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
    public class CategoriaBL
    {
        private static CategoriaBL _instance;
        public static CategoriaBL Instance { get { return _instance; } }

        public List<Category> SellecALL()
        {
            List<Category> result;
            try
            {
                result = CategoriaDAL.Instance.SellectAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Insert(Category entity)
        {
            bool result = false;
            try
            {
                result = CategoriaDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }

        public bool Update(Category entity)
        {
            bool result = false;
            try
            {
                result = CategoriaDAL.Instance.Update(entity);
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

