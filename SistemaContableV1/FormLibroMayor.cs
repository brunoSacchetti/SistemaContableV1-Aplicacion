using K4os.Compression.LZ4.Encoders;
using MongoDB.Driver;
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
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaContableV1
{
    public partial class FormLibroMayor : Form
    {


        Blockchain blockchainAsientos;
        IMongoCollection<Blockchain> blockChain;
        IMongoDatabase database;

        public FormLibroMayor()
        {
            InitializeComponent();

        }

        private void FormLibroMayor_Load(object sender, EventArgs e)
        {
            PlanCuentas pC = new PlanCuentas();
            pC.mostrarCuentas(dataCuentasMayor);
            var client = new MongoClient("mongodb://localhost:27017/");
            database = client.GetDatabase("Blockchain");

            blockChain = database.GetCollection<Blockchain>("blockchainAsientos");
            blockchainAsientos = blockChain.Find(d => true).FirstOrDefault();

            if (blockchainAsientos == null)
            {
                blockchainAsientos = new Blockchain();
            }
        }



        private void btnEnviar_Click(object sender, EventArgs e)
        {
            listBoxDebe.Items.Clear();
            listBoxHaber.Items.Clear();
            labelCuenta.Text = txtCuentaMayor.Text;

            //definimos las fechas
            DateTime fechaInicio = dateTimeFechaInicio.Value;
            DateTime fechaFin = dateTimeFechaFin.Value;

            //definimos los objetos a usar
            List<decimal> montoDebe = new List<decimal>();
            List<decimal> montoHaber = new List<decimal>();

            if (fechaFin < fechaInicio)
            {
                MessageBox.Show("La fecha de fin debe ser igual o posterior a la fecha de inicio. Por favor, selecciona un rango válido.");

            }
            else
            {
                /*var bloquesFiltrados = blockchainAsientos.Cadena
                .Where(b => b.TimeStamp >= fechaInicio && b.TimeStamp <= fechaFin)
                .ToList(); */
                
                //for(int k = 0; k < blockchainAsientos.Cadena.Count; k++)
                //{
                    //var block = blockchainAsientos.Cadena[k];

                    //if (block.TimeStamp >= fechaInicio && block.TimeStamp <= fechaFin)
                    //{
                        foreach (var asiento in blockchainAsientos.Cadena)
                        {
                            if (asiento.Index != 0)
                            {
                                if (asiento.Data.ContieneCuentaDebe(txtCuentaMayor.Text))
                                {
                                    for (int i = 0; i < asiento.Data.cuentasDebe.Count; i++)
                                    {
                                        if (asiento.Data.cuentasDebe[i].nombreCuenta == txtCuentaMayor.Text)
                                        {
                                            montoDebe.Add((decimal)asiento.Data.cuentasDebe[i].saldoDebe);
                                            listBoxDebe.Items.Add(asiento.Data.cuentasDebe[i].saldoDebe.ToString());
                                        }
                                    }
                                }

                                if (asiento.Data.ContieneCuentaHaber(txtCuentaMayor.Text))
                                {
                                    for (int j = 0; j < asiento.Data.cuentasHaber.Count; j++)
                                    {
                                        if (asiento.Data.cuentasHaber[j].nombreCuenta == txtCuentaMayor.Text)
                                        {
                                            montoHaber.Add((decimal)asiento.Data.cuentasHaber[j].saldoHaber);
                                            listBoxHaber.Items.Add(asiento.Data.cuentasHaber[j].saldoHaber.ToString());
                                        }
                                    }
                                }

                            }
                        }
                    //}
                //}
                //decimal tDebe = montoDebe.Aggregate(0, (acc, x) => (decimal)acc + x);
                //decimal tHaber = montoHaber.Aggregate(0, (acc, x) => (decimal)acc + x);

                decimal tDebe = montoDebe.Sum();
                decimal tHaber = montoHaber.Sum();

                lblDebe.Text = "Total Debe: " + tDebe;
                lblHaber.Text = "Total Haber: " + tHaber;
                if (tDebe > tHaber)
                {
                    labelTotalSaldo.Text = "Saldo deudor: " + (tDebe - tHaber);
                }
                else if (tDebe < tHaber)
                {
                    labelTotalSaldo.Text = "Saldo Acreedor: " + (tHaber - tDebe);
                }
                else
                {
                    labelTotalSaldo.Text = "Saldo nulo";
                }

                MessageBox.Show("Fechas iguales");
            }
        }

            private void dataCuentasMayor_CellClick_1(object sender, DataGridViewCellEventArgs e)
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataCuentasMayor.Rows[e.RowIndex];
                    string id = selectedRow.Cells["id"].Value.ToString();
                    string cuenta = selectedRow.Cells["cuenta"].Value.ToString();

                    txtCuentaMayor.Text = cuenta;
                }

            }


        }
    }


