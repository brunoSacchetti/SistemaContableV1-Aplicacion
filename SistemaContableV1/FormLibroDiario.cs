﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;
using MongoDB.Driver;
using SistemaContableV1.Clases;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace SistemaContableV1
{
    public partial class FormLibroDiario : Form
    {


        Blockchain blockchainAsientos;
        IMongoCollection<Blockchain> blockChain;
        IMongoDatabase database;

        public FormLibroDiario()
        {
            InitializeComponent();

        }

        private void FormLibroDiario_Load(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/");
            database = client.GetDatabase("Blockchain");

            blockChain = database.GetCollection<Blockchain>("blockchainAsientos");
            // asiganamos los valores de las colecciones a variables
            blockchainAsientos = blockChain.Find(d => true).FirstOrDefault();

            //var firstDocument = blockChain.Find(d => true).FirstOrDefault();
            //var firstDocument = blockChain.Find(d => true).First();

            if (blockchainAsientos == null)
            {
                blockchainAsientos = new Blockchain();
            }

        }





        private void btnImportarCuenta_Click(object sender, EventArgs e)
        {
            PlanCuentas pC = new PlanCuentas();
            pC.mostrarCuentas(dataCuentas);

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

        private void dataCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataCuentas.Rows[e.RowIndex];
                string id = selectedRow.Cells["id"].Value.ToString();
                string cuenta = selectedRow.Cells["cuenta"].Value.ToString();

                dataLibroDiario.Rows.Add(id, cuenta);
            }
        }

        private void btnEliminaCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataLibroDiario.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow selectedRow in dataLibroDiario.SelectedRows)
                    {
                        dataLibroDiario.Rows.Remove(selectedRow);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardarAsiento_Click(object sender, EventArgs e)
        {

            List<Cuenta> debe = new List<Cuenta>();
            List<Cuenta> haber = new List<Cuenta>();
            AsientoContable asientoContable = new AsientoContable();


            foreach (DataGridViewRow fila in dataLibroDiario.Rows)
            {
                if (fila.IsNewRow)
                {
                    // Ignora la fila de nueva creación (si la hay)
                    continue;
                }
                try
                {

                    Cuenta cuenta = new Cuenta
                    {
                        nombreCuenta = fila.Cells["Cuentas"].Value.ToString(),
                        saldoDebe = Convert.ToDecimal(fila.Cells["Debe"].Value),
                        saldoHaber = Convert.ToDecimal(fila.Cells["Haber"].Value),
                    };

                    if (cuenta.saldoDebe == 0 || string.IsNullOrWhiteSpace(fila.Cells["Debe"].Value.ToString()))
                    {
                        //haber.Add(cuenta);
                        asientoContable.cuentasHaber.Add(cuenta);
                        //MessageBox.Show("ESTOY EN EL HABER");
                    }
                    else if (cuenta.saldoHaber == 0 || string.IsNullOrWhiteSpace(fila.Cells["Haber"].Value.ToString()))
                    {
                        //debe.Add(cuenta);
                        asientoContable.cuentasDebe.Add(cuenta);
                        //MessageBox.Show("ESTOY EN EL DEBE");
                    }

                    //MessageBox.Show("Cuenta: " + cuenta.nombreCuenta);
                    //MessageBox.Show("DEBE: " + cuenta.saldoDebe);
                    //MessageBox.Show("HABER: " + cuenta.saldoHaber);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar valores validos");
                }

            }

            //fecha del asiento
            DateTime fechaAsiento = dateAsiento.Value;
            asientoContable.fechaAsiento = fechaAsiento;

            //AsientoContable asientoContable = new AsientoContable(debe, haber);

            //if (debe.Count > 0 || haber.Count > 0)
            if (asientoContable.cuentasDebe.Count > 0 || asientoContable.cuentasHaber.Count > 0)
            {
                try
                {
                    //blockchainAsientos.AddBlock(new Block(DateTime.Now, null, asientoContable));
                    blockchainAsientos.AddBlock(new Block(DateTime.Now, null, asientoContable));
                    blockChain.FindOneAndDelete(database => true);

                    blockChain.InsertOne(blockchainAsientos);

                    //blockChain.ReplaceOne(d => true, blockchainAsientos);



                    MessageBox.Show("Se agrego correctamente el asiento a la BLOCKCHAIN");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NO se pudo agregar el asiento a la BLOCKCHAIN");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar al menos una cuenta para poder guardar el asiento en la BLOCKCHAIN");
            }



            dataLibroDiario.Rows.Clear();
            debe.Clear();
            haber.Clear();
        }
    }
}
