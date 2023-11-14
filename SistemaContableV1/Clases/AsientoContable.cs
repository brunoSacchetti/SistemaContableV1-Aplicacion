using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContableV1.Clases
{
    public class AsientoContable
    {
        public List<Cuenta> cuentasDebe = new List<Cuenta>();
        public List<Cuenta> cuentasHaber = new List<Cuenta>();

        public AsientoContable() { }

        public AsientoContable(List<Cuenta> cuentasDebe, List<Cuenta> cuentasHaber)
        {
            this.cuentasDebe = cuentasDebe;
            this.cuentasHaber = cuentasHaber;
        }

        public bool ContieneCuenta(string cuentaBuscada)
        {
            foreach (Cuenta cuenta in cuentasDebe)
            {
                if (cuenta.nombreCuenta.Equals(cuentaBuscada, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            foreach (Cuenta cuenta in cuentasHaber)
            {
                if (cuenta.nombreCuenta.Equals(cuentaBuscada, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
