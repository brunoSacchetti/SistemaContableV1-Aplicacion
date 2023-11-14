using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaContableV1
{
    public partial class FormLibroMayor : Form
    {

        private Blockchain blockchainAsientos;

        private void btnEnviar_Click(object sender, EventArgs e)
        {


        }

        Blockchain asientos;
        List<Cuenta> cuentas;
        MySqlConnection connection; // Asumiendo que tienes una clase MySqlConnection para gestionar la conexión MySQL

        public FormLibroMayor()
        {
            InitializeComponent();
            // Inicializa tu conexión a MySQL
            
        }

        
        private void FormLibroMayor_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }














        /*public void recibirBlockchain(Blockchain blockchain)
        {
            blockchainAsientos = blockchain;
        }*/


        /*DateTime fechaInicio = dateTimeFechaInicio.Value;
        DateTime fechaFinal = dateTimeFechaFin.Value;
        string nombreCuenta = txtCuentaMayor.Text;
        decimal saldoAcumulado = 0;

        foreach (Block bloque in blockchainAsientos.Cadena)
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
        MessageBox.Show("Saldo: " + saldoAcumulado); */




    }
}
