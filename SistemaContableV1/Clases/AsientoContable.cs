﻿using System;
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
