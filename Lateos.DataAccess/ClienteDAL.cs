using Lateos.Entities;
using Lateos.DataAccess.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Lateos.DataAccess
{
    public class ClienteDAL
    {

        private static ClienteDAL _instance;

        public static ClienteDAL Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new ClienteDAL();
                }
                return _instance;
            }
        }

        public List<Cliente> SellectAll()
        {
            List<Cliente> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.clientes.Include(x => x.IdCliente).ToList();
            }
            return result;
        }

        public Cliente SellectById(int id)
        {
            Cliente result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.clientes
                    .FirstOrDefault(x => x.IdCliente == id);
            }
            return result;
        }

        public List<Registro> SellecProductotById(int id)
        {
            List<Registro> result = null;
            using (CFDataContext _context = new CFDataContext())
            {
                result = _context.Registros.Where(x => x.IdRegistro.Equals(id)).ToList();
            }
            return result;
        }

        public bool Insert(Cliente entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {
                var query = _context.clientes.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));
                if (query == null)
                {
                    _context.clientes.Add(entity);
                    result = _context.SaveChanges() > 0;
                }
                return result;
            }
        }

        public bool Update(Cliente entity)
        {
            bool result = false;
            using (CFDataContext _context = new CFDataContext())
            {

                var query = _context.clientes.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));


                if (query == null)
                {
                    _context.Entry(entity).State = EntityState.Modified;
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }







        }
    }
    }
