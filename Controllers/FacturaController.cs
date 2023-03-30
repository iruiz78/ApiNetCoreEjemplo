using Microsoft.AspNetCore.Mvc;
using WebApplication9.Modelos;
using WebApplication9.Repocitorio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : BaseController<IDBGestor<Factura>,Factura>
    {
        public FacturaController(IDBGestor<Factura> repo) : base(repo) 
        {
        }       
    }
}
