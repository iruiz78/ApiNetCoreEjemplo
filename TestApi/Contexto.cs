using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication9.ContextoSQL;

namespace TestApi
{
    public class Contexto 
    {
        protected ContextoGenerico GetContexto(string name)
        {
            var opciones = new DbContextOptionsBuilder<ContextoGenerico>()
                .UseInMemoryDatabase(name).Options;

            var dbContext = new ContextoGenerico(opciones);
            return dbContext;
        }
    }
}
