using Lateos.DataAccess.AppContext;
using Lateos.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lateos.DataAccess
{
    public class EmpresaDAL
    {
        //--Instancia
        private static EmpresaDAL _instance;

        public static EmpresaDAL Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new EmpresaDAL();
                }
                return _instance;
            }
        }
        //-------------------------------------------------------
        /*
        public List<Empresa> SellectAll()
        {
            List<Empresa> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.empresas.Include(x =>x.Empresa).ToList();
            }
            return result;
        }
        */


        //-----------------------------------------------------
        public Empresa SellectById(int id)
        {
            Empresa result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.empresas
                    .FirstOrDefault(x => x.IdEmprresa == id);
            }
            return result;
        }

        //----------------------------------------------------------------


                public List<Empresa> SellecProductotById(int id)
        {
            List<Empresa> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.empresas.Where(x => x.IdEmprresa.Equals(id)).ToList();
            }
            return result;
        }


        //---------------------------------------------------------------------
        public bool Insert(Empresa entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.empresas.FirstOrDefault(x => x.NombreComercial.Equals(entity.NombreComercial));
                if (query == null)
                {
                    _context.empresas.Add(entity);
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }
        }


        //------------------------------------------------------------------------------
        public bool Update(Empresa entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {

                var query = _context.empresas.FirstOrDefault(x => x.NombreComercial.Equals(entity.NombreComercial));


                if (query == null)
                {
                    _context.Entry(entity).State = EntityState.Modified;
                    result = _context.SaveChanges() > 0;

                }

                return result;
            }
        }
        //--------------------------------------------------------------------



    }
}
