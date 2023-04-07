.using Microsoft.EntityFrameworkCore.Migrations.Operations;
using WebApplication9.Controllers;
using WebApplication9.Modelos;
using WebApplication9.Repocitorio;

namespace TestApi
{
    public class UnitClientes : Contexto
    {
        private readonly ClientesController _cliente;
        private readonly IDBGestor<Cliente> _generic;

        public UnitClientes()
        {
            var name = Guid.NewGuid().ToString();
            _generic = new ClienteRepositorio(GetContexto(name));
            _cliente = new ClientesController(_generic);
        }

        [Fact]
        public void Add_Ok()
        {
            // preparacion
            var cliente = new Cliente();
            cliente.Nombre = "ricardo";
            cliente.Apellido = "Lopez";

            cliente = _cliente.Post(cliente);

            Assert.True(cliente.Id > 0);
        }

        [Fact]
        public void Get_All_OK()
        {
            var cliente = _cliente.Post(new Cliente
                                            {
                                                Nombre = "eee",
                                                Apellido = "ruiz"
                                            });

            Assert.True(cliente.Id > 0);
            var result = _cliente.Get();

            Assert.NotNull(result);
            Assert.IsType<List<Cliente>>(result);
            Assert.True(result.Any());
        }


        [Fact]
        public void Get_All_Empty()
        {  
            var result = _cliente.Get();

            Assert.NotNull(result);
            Assert.IsType<List<Cliente>>(result);
            Assert.Empty(result);
        }

        [Fact]
        public void GetById_OK()
        {
            var cliente = new Cliente
            {
                Nombre = "Nacho",
                Apellido = "Ruiz"
            };
            cliente = _cliente.Post(cliente);

            Assert.True(cliente.Id > 0);
            var clienteById = _cliente.Get(cliente.Id);

            Assert.IsType<Cliente>(clienteById);
            Assert.Equal(cliente, clienteById);
        }

        [Fact]
        public void GetById_Empty()
        {
            var cliente = _cliente.Get(1);
            Assert.Null(cliente);            
        }
    }
}