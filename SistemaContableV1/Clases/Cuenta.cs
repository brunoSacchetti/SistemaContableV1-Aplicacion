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
        public decimal saldoDebe {  get; set; }

        public decimal saldoHaber { get; set; }
    }
}
