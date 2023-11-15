using System;
using System.Collections.Generic;
using System.Configuration;
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

        public bool ContieneCuentaDebe(string cuentaBuscada)
        {
            foreach (Cuenta cuenta in cuentasDebe)
            {
                if (cuenta.nombreCuenta.Equals(cuentaBuscada, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        public bool ContieneCuentaHaber(string cuentaBuscada)
        {
            foreach (Cuenta cuenta in cuentasHaber)
            {
                if (cuenta.nombreCuenta.Equals(cuentaBuscada, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        /*public string ObtenerCuenta(string cuentaBuscada)
        {
            foreach (Cuenta cuenta in cuentasDebe)
            {
                if (cuenta.nombreCuenta.Equals(cuentaBuscada, StringComparison.OrdinalIgnoreCase))
                {
                    return cuenta.nombreCuenta;
                }
            }

            foreach (Cuenta cuenta in cuentasHaber)
            {
                if (cuenta.nombreCuenta.Equals(cuentaBuscada, StringComparison.OrdinalIgnoreCase))
                {
                    return cuenta.nombreCuenta;
                }
            }

            return null; // Devuelve null si la cuenta no se encuentra en ninguna lista.
        }*/
    }
}
