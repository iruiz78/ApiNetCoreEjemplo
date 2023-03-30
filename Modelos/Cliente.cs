using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }
    }

    public class ClienteEntrada
    {
        public string? Nombre { get; set; }

        [StringLength(5, ErrorMessage = "El nombre no puede tener más de 5 caracteres.")]
        public string? Apellido { get; set; }
    }
}
