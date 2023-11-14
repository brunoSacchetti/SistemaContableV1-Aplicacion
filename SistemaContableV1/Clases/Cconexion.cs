using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContableV1.Clases
{
    public class Cconexion
    {
        MySqlConnection conex = new MySqlConnection();
        static string servidor = "localhost";
        static string bd = "cuentas";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
        
        public MySqlConnection establecerConexion()
        {
            try { 
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                //MessageBox.Show("Se estableció la conexion correctamente");
            } catch(Exception e) {
                MessageBox.Show("No se pudo conectar a la base de datos. Error: " + e.ToString());
            }
            return conex;
        }

        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
