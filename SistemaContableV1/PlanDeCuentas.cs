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

namespace SistemaContableV1
{
    public partial class PlanDeCuentas : Form
    {
        private int n = 0;
        public PlanDeCuentas()
        {
            InitializeComponent();
            PlanCuentas planCuentas = new PlanCuentas();
            planCuentas.mostrarCuentas(dPlanCuentas);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PlanCuentas plan = new PlanCuentas();
            if (txtRubro.Text.Equals("") || txtCuenta.Text.Equals(""))
            {

                MessageBox.Show("Debe ingresar una cuenta para poder guardar");

            }
            else
            {
                plan.guardarCuentas(txtRubro, txtCuenta);
                plan.mostrarCuentas(dPlanCuentas);
            }
        }

        private void LimpiarTextBoxes()
        {
            txtRubro.Text = "";
            txtCuenta.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PlanCuentas plan = new PlanCuentas();
            plan.modificarCuentas(txtIde, txtRubro, txtCuenta);
            plan.mostrarCuentas(dPlanCuentas);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PlanCuentas plan = new PlanCuentas();
            plan.eliminarCuentas(txtIde);
            plan.mostrarCuentas(dPlanCuentas);
        }

        private void dPlanCuentas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PlanCuentas plan = new PlanCuentas();
            plan.seleccionarCuenta(dPlanCuentas, txtIde, txtRubro, txtCuenta);
            plan.mostrarCuentas(dPlanCuentas);
        }
    }
}
