using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SistemaContableV1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FondoMenuPrincipal menuPrincipal = new FondoMenuPrincipal();
            menuPrincipal.Show();
            CargarFormularioSecundario(menuPrincipal);
        }

        private void MostrarContenido1()
        {
            // Lógica para cargar el contenido de la sección 1 en el Panel
            panel.Controls.Clear(); // Limpia el contenido existente
                                    // Agrega los controles y elementos que desees mostrar en la sección 1
        }

        private void MostrarContenido2()
        {
            // Lógica para cargar el contenido de la sección 2 en el Panel
            panel.Controls.Clear();
            // Agrega los controles y elementos que desees mostrar en la sección 2
        }

        private void CargarFormularioSecundario(Form formulario)
        {
            panel.Controls.Clear(); // Limpia cualquier contenido existente en el Panel
            formulario.FormBorderStyle = FormBorderStyle.None; // Opcional: quita los bordes del formulario secundario
            formulario.Dock = DockStyle.Fill; // Opcional: hace que el formulario secundario llene todo el Panel
            formulario.TopLevel = false; // Asegúrate de que el formulario secundario no sea de nivel superior
            panel.Controls.Add(formulario); // Agrega el formulario secundario al Panel
            formulario.Show(); // Muestra el formulario secundario
        }

        private void btnRegistrarEmpresa_Click(object sender, EventArgs e)
        {
            RegistroEmpresa regEmpresa = new RegistroEmpresa();
            CargarFormularioSecundario(regEmpresa);
        }

        private void btnPlanCuenta_Click(object sender, EventArgs e)
        {
            PlanDeCuentas planDeCuentasForm = new PlanDeCuentas();

            // Mostrar el formulario PlanDeCuentas
            CargarFormularioSecundario(planDeCuentasForm);
        }

        private void btnLibroDiario_Click(object sender, EventArgs e)
        {
            FormLibroDiario formLibroDiario = new FormLibroDiario();
            CargarFormularioSecundario(formLibroDiario);
        }

        private void btnLibroMayor_Click(object sender, EventArgs e)
        {
            
        }
    }
}