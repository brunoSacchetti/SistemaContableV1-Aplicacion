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
    public partial class RegistroEmpresa : Form
    {

        private int n = 0;
        public RegistroEmpresa()
        {
            InitializeComponent();
            this.TopLevel = false; // Establece TopLevel en false
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //guardamos los datos en el data grid view
            int n = dataGridViewEmpresas.Rows.Add();

            //colocamos la informacion
            dataGridViewEmpresas.Rows[n].Cells[0].Value = txtNombre.Text;
            dataGridViewEmpresas.Rows[n].Cells[1].Value = txtCiudad.Text;
            dataGridViewEmpresas.Rows[n].Cells[2].Value = txtTelefono.Text;
            dataGridViewEmpresas.Rows[n].Cells[3].Value = txtEmail.Text;

            //limpiamos los text box
            txtNombre.Text = "";
            txtCiudad.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";

        }

        private void dataGridViewEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try {
                if (n != -1)
                {

                    dataGridViewEmpresas.Rows.RemoveAt(n);

                }
            }catch (Exception ex)
            {
                MessageBox.Show("No se puede borrar una fila vacia");
            }

            }

    }
}
