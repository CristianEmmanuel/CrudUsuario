using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudUsuario.Entities
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Identificacion { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public decimal NumeroTelefono { get; set; }
        public string Estado { get; set; }
        public Atributos Atributos { get; set; }
       
    }
}
