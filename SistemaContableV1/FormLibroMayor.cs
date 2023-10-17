using SistemaContableV1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaContableV1
{
    public partial class FormLibroMayor : Form
    {

        public FormLibroMayor()
        {
            InitializeComponent();
        }

        /*public FormLibroMayor(Blockchain blockchain)
        {
            InitializeComponent();
            this.blockchain = blockchain;
        }*/

        /*public decimal calcularLibroMayor(Blockchain blockchain)
        {
            DateTime fechaInicio = dateTimeFechaInicio.Value;
            DateTime fechaFinal = dateTimeFechaFin.Value;
            string nombreCuenta = txtCuentaMayor.Text;
            decimal saldoAcumulado = 0;

            foreach (Block bloque in blockchain.Cadena)
            {
                if (bloque.TimeStamp >= fechaInicio && bloque.TimeStamp <= fechaFinal)
                {
                    foreach (Cuenta cuenta in bloque.Data.cuentasDebe)
                    {
                        if (cuenta.nombreCuenta == nombreCuenta)
                        {
                            saldoAcumulado += cuenta.saldoDebe;
                        }
                    }
                    foreach (Cuenta cuenta in bloque.Data.cuentasHaber)
                    {
                        if (cuenta.nombreCuenta == nombreCuenta)
                        {
                            saldoAcumulado -= cuenta.saldoHaber;
                        }
                    }
                }
            }
            return saldoAcumulado;
        }*/

        private void btnMayorUnaCuenta_Click(object sender, EventArgs e)
        {

        }
    }
}
