using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContableV1.Clases
{
    internal class PlanCuentas
    {
        public void mostrarCuentas(DataGridView tablaCuentas)
        {
            Cconexion cconexion = new Cconexion();

            try
            {
                String query = "select * from cuentas";
                tablaCuentas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, cconexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCuentas.DataSource = dt;
                cconexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la carga de cuentas. Error: " + ex.Message);
            }
        }

        public void guardarCuentas(TextBox rubro, TextBox cuenta)
        {
            Cconexion cconexion = new Cconexion();

            try
            {
                String query = "insert into cuentas(rubro,cuenta)" + "values('" + rubro.Text + "','" + cuenta.Text + "');";

                MySqlCommand myCommand = new MySqlCommand(query, cconexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Se guardó correctamente la cuenta");
                while (reader.Read())
                {

                }
                cconexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la carga de cuentas. Error: " + ex.Message);
            }
        }

        public void seleccionarCuenta( DataGridView planCuentas,TextBox id, TextBox rubro, TextBox cuenta)
        {
            Cconexion cconexion = new Cconexion();

            try
            {
                id.Text = planCuentas.CurrentRow.Cells[0].Value.ToString();
                rubro.Text = planCuentas.CurrentRow.Cells[1].Value.ToString();
                cuenta.Text = planCuentas.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la carga de cuentas. Error: " + ex.Message);
            }
        }

        public void modificarCuentas(TextBox id, TextBox rubro, TextBox cuenta)
        {
            Cconexion cconexion = new Cconexion();

            try
            {
                String query = "update cuentas set rubro ='" +
                    rubro.Text + "', cuenta='" + cuenta.Text + "' where id ='" + id.Text + "';";

                MySqlCommand myCommand = new MySqlCommand(query, cconexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Se modificó correctamente la cuenta");
                while (reader.Read())
                {

                }
                cconexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la actualizacion de la cuenta. Error: " + ex.Message);
            }
        }
        public void eliminarCuentas(TextBox id)
        {
            Cconexion cconexion = new Cconexion();

            try
            {
                String query = "delete from cuentas where id = '" + id.Text + "';";

                MySqlCommand myCommand = new MySqlCommand(query, cconexion.establecerConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Se eliminó correctamente la cuenta");
                while (reader.Read())
                {

                }
                cconexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la eliminacion de la cuenta. Error: " + ex.Message);
            }
        }
    }
}
