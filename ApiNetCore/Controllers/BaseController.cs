using Microsoft.AspNetCore.Mvc;
using WebApplication9.Repocitorio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TRepositiorio, TModel> : ControllerBase
        where TRepositiorio : IDBGestor<TModel>
    {
        private readonly IDBGestor<TModel> _gestor;

        public BaseController(IDBGestor<TModel> gestor)
        {
            _gestor = gestor;
        }

        // GET: api/<BaseController>
        [HttpGet]
        public IEnumerable<TModel> Get()
        {
            return _gestor.Get();
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public TModel Get(int id)
        {
            return _gestor.Get(id);
        }

        // POST api/<BaseController>
        [HttpPost]
        public TModel Post([FromBody] TModel model)
        {
            return _gestor.Add(model);
        }

        // PUT api/<BaseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
