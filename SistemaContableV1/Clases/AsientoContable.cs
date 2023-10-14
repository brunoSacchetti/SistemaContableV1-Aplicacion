using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContableV1.Clases
{
    internal class AsientoContable
    {
        public List<Cuenta> cuentasDebe;
        public List<Cuenta> cuentasHaber;

        public AsientoContable() { }

        public AsientoContable(List<Cuenta> cuentasDebe, List<Cuenta> cuentasHaber)
        {
            this.cuentasDebe = cuentasDebe;
            this.cuentasHaber = cuentasHaber;
        }
    }
}
