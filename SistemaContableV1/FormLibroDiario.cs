using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace SistemaContableV1
{
    public partial class FormLibroDiario : Form
    {
        public FormLibroDiario()
        {
            InitializeComponent();


        }

        // Crear una instancia de Excel
        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

        // Obtener los datos del archivo Excel y cargarlos en un DataTable
        System.Data.DataTable dt = new System.Data.DataTable();

        private void btnImportarCuenta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de Excel|*.xlsx;*.xls";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string archivoExcel = openFileDialog1.FileName;

                // Crear una instancia de Excel
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook excelWorkbook = excelApp.Workbooks.Open(archivoExcel);
                Worksheet excelWorksheet = excelWorkbook.Sheets[1]; // Suponiendo que los datos están en la primera hoja

                // Obtener los datos del archivo Excel y cargarlos en un DataTable
                System.Data.DataTable dt = new System.Data.DataTable();
                //int totalColumns = excelWorksheet.UsedRange.Columns.Count;
                int rowCount = excelWorksheet.UsedRange.Rows.Count;
                int colCount = excelWorksheet.UsedRange.Columns.Count;

                for (int col = 1; col <= colCount; col++)
                {
                    string header = excelWorksheet.Cells[1, col].Value.ToString();
                    dt.Columns.Add(header);
                }

                // Leer datos y agregar filas al DataTable
                for (int row = 2; row <= rowCount; row++)
                {
                    DataRow dr = dt.NewRow();
                    for (int col = 1; col <= colCount; col++)
                    {
                        dr[col - 1] = excelWorksheet.Cells[row, col].Value != null ? excelWorksheet.Cells[row, col].Value.ToString() : string.Empty;
                    }
                    dt.Rows.Add(dr);
                }

                // Cerrar Excel
                excelWorkbook.Close();
                excelApp.Quit();

                // Enlazar el DataTable al DataGridView
                dataCuentas.DataSource = dt;
            }
        }

        private void dataCuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verificar si se hace doble clic en la columna y fila deseada
            int columnIndex = 1; // Cambiar al índice de la columna deseada (por ejemplo, 0 para la primera columna)
            int targetRow = e.RowIndex; // Obtener el índice de la fila en la que se hizo doble clic

            if (targetRow >= 0 && targetRow < dataCuentas.Rows.Count && e.ColumnIndex == columnIndex)
            {
                // Copiar la fila seleccionada de dataGridView1
                DataGridViewRow selectedRow = dataLibroDiario.Rows[targetRow].Clone() as DataGridViewRow;
                for (int i = 0; i < dataLibroDiario.Columns.Count; i++)
                {
                    selectedRow.Cells[i].Value = dataLibroDiario.Rows[targetRow].Cells[i].Value;
                }

                // Agregar la fila copiada a dataGridView2
                dataLibroDiario.Rows.Add(selectedRow);


            }
        }
    }
}
