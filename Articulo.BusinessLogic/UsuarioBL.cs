using Lateos.DataAccess;
using Lateos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulo.BusinessLogic
{
    public class UsuarioBL
    {
        private static UsuarioBL _instance;
        public static UsuarioBL Instance { get { return _instance; } }


        public List<Usuario> SelectAll()
        {
            List<Usuario> result = null;
            try
            {
                result = UsuarioBL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }





        public bool Insert(Usuario entity)
        {
            bool result = false;
            try
            {
                result = UsuarioDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }

        public bool Update(Usuario entity)
        {
            bool result = false;
            try
            {
                result = UsuarioDAL.Instance.Update(entity);
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
                result = UsuarioBL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }
    }
}
