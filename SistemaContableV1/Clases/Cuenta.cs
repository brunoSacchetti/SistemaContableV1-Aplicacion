using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContableV1.Clases
{
    internal class Cuenta
    {
        //public string _id { get; set; }
        public string nombreCuenta { get; set; }
        public int codigoCuenta { get; set; }

        public Cuenta(string nombre, int codigo)
        {
            this.nombreCuenta = nombre;
            this.codigoCuenta = codigo;
        }
    }
}
