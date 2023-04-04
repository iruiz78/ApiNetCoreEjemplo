using WebApplication9.ContextoSQL;
using WebApplication9.Modelos;

namespace WebApplication9.Repocitorio
{
    public class ClienteRepositorio : IDBGestor<Cliente>
    {

        private readonly ContextoGenerico _dbContext;
        public ClienteRepositorio(ContextoGenerico dbContext)
        {
            _dbContext = dbContext;
        }
        public Cliente Add(Cliente model)
        {
            var cli =  _dbContext.Add(model).Entity;  
            _dbContext.SaveChanges();
            return cli;
        }

        public bool Delete(Cliente model)
        {
            _dbContext.clientes.Remove(model);
            return true;
        }

        public Cliente Get(int id)
        {
            return _dbContext.clientes.FirstOrDefault(r => r.Id == id);
        }

        public List<Cliente> Get()
        {
            return _dbContext.clientes.ToList<Cliente>();
        }
    }
}
