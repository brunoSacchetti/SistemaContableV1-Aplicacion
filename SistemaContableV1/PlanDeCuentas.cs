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
    public partial class PlanDeCuentas : Form
    {
        private int n = 0;
        public PlanDeCuentas()
        {
            InitializeComponent();
            this.TopLevel = false; // Establece TopLevel en false
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dataGridViewPlanCuentas.SelectedRows.Count > 0)
            {
                // Estás en modo de edición, actualiza la fila seleccionada
                DataGridViewRow selectedRow = dataGridViewPlanCuentas.SelectedRows[0];
                selectedRow.Cells["IdCuenta"].Value = textId.Text;
                selectedRow.Cells["Rubro"].Value = txtRubro.Text;
                selectedRow.Cells["NumeroCuenta"].Value = txtNumeroCuenta.Text;
                selectedRow.Cells["Descripcion"].Value = txtDescripcion.Text;
            }
            else
            {
                // Estás en modo de inserción, agrega una nueva fila
                int n = dataGridViewPlanCuentas.Rows.Add();
                dataGridViewPlanCuentas.Rows[n].Cells["IdCuenta"].Value = textId.Text;
                dataGridViewPlanCuentas.Rows[n].Cells["Rubro"].Value = txtRubro.Text;
                dataGridViewPlanCuentas.Rows[n].Cells["NumeroCuenta"].Value = txtNumeroCuenta.Text;
                dataGridViewPlanCuentas.Rows[n].Cells["Descripcion"].Value = txtDescripcion.Text;
            }

            // Limpia los TextBoxes después de guardar
            LimpiarTextBoxes();
        }

        private void LimpiarTextBoxes()
        {
            textId.Text = "";
            txtRubro.Text = "";
            txtNumeroCuenta.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dataGridViewPlanCuentas.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = dataGridViewPlanCuentas.SelectedRows[0];

                // Obtén los valores de las celdas de la fila seleccionada y colócalos en los TextBoxes //Cuando se refiere a Cells ES EL NOMBRE QUE LE PUSIMOS A LAS COLUMNAS
                textId.Text = selectedRow.Cells["IdCuenta"].Value.ToString();
                txtRubro.Text = selectedRow.Cells["Rubro"].Value.ToString();
                txtNumeroCuenta.Text = selectedRow.Cells["NumeroCuenta"].Value.ToString();
                txtDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
            }
            else
            {
                // Si no hay fila seleccionada, muestra un mensaje de advertencia
                MessageBox.Show("Por favor, selecciona una fila para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlanCuentas.SelectedRows.Count > 0)
            {

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta fila?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes)
                {
                    // Si el usuario confirma la eliminación, obtén la fila seleccionada
                    DataGridViewRow selectedRow = dataGridViewPlanCuentas.SelectedRows[0];

                    // Elimina la fila seleccionada del DataGridView
                    dataGridViewPlanCuentas.Rows.Remove(selectedRow);
                }
            }
            else
            {
                // Si no hay fila seleccionada, muestra un mensaje de advertencia
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }


    }
}
