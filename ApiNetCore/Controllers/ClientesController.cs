using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication9.ContextoSQL;
using WebApplication9.Modelos;
using WebApplication9.Repocitorio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : BaseController<IDBGestor<Cliente>, Cliente>
    {
        public ClientesController(IDBGestor<Cliente> repo) : base (repo)
        {
        }      
    }
}
