using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContableV1.Clases
{
    internal class AsientoContable
    {
        public Cuenta cuentaDebe { get; set; }
        public Cuenta cuentaHaber { get; set; }
        public double saldoDebe { get; set; }
        public double saldoHaber { get; set; }

        public AsientoContable() { }
        public AsientoContable(Cuenta cuentaDebe, Cuenta cuentaHaber, double saldoDebe, double saldoHaber)
        {
            this.cuentaDebe = cuentaDebe;
            this.cuentaHaber = cuentaHaber;
            this.saldoDebe = saldoDebe;
            this.saldoHaber = saldoHaber;
        }

    }
}
