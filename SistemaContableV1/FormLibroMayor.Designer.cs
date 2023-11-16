namespace SistemaContableV1
{
    partial class FormLibroMayor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimeFechaInicio = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dateTimeFechaFin = new DateTimePicker();
            btnEnviar = new Button();
            txtCuentaMayor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnTodasCuentas = new Button();
            listBoxDebe = new ListView();
            listBoxHaber = new ListView();
            label6 = new Label();
            label7 = new Label();
            dataCuentasMayor = new DataGridView();
            lblDebe = new Label();
            lblHaber = new Label();
            labelCuenta = new Label();
            labelTotalSaldo = new Label();
            dataTodasLasCuentas = new DataGridView();
            colCuenta = new DataGridViewTextBoxColumn();
            colDeudor = new DataGridViewTextBoxColumn();
            colAcreedor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataCuentasMayor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataTodasLasCuentas).BeginInit();
            SuspendLayout();
            // 
            // dateTimeFechaInicio
            // 
            dateTimeFechaInicio.Location = new Point(12, 153);
            dateTimeFechaInicio.Name = "dateTimeFechaInicio";
            dateTimeFechaInicio.Size = new Size(212, 23);
            dateTimeFechaInicio.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 135);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 207);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha Fin";
            // 
            // dateTimeFechaFin
            // 
            dateTimeFechaFin.Location = new Point(12, 225);
            dateTimeFechaFin.Name = "dateTimeFechaFin";
            dateTimeFechaFin.Size = new Size(215, 23);
            dateTimeFechaFin.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(55, 334);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(120, 53);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtCuentaMayor
            // 
            txtCuentaMayor.Location = new Point(12, 290);
            txtCuentaMayor.Name = "txtCuentaMayor";
            txtCuentaMayor.Size = new Size(212, 23);
            txtCuentaMayor.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 272);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre de la Cuenta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(440, 9);
            label4.Name = "label4";
            label4.Size = new Size(184, 37);
            label4.TabIndex = 7;
            label4.Text = "LIBRO MAYOR";
            // 
            // btnTodasCuentas
            // 
            btnTodasCuentas.Location = new Point(877, 115);
            btnTodasCuentas.Name = "btnTodasCuentas";
            btnTodasCuentas.Size = new Size(120, 54);
            btnTodasCuentas.TabIndex = 8;
            btnTodasCuentas.Text = "Libro Mayor de Todas las Cuentas";
            btnTodasCuentas.UseVisualStyleBackColor = true;
            btnTodasCuentas.Click += btnTodasCuentas_Click;
            // 
            // listBoxDebe
            // 
            listBoxDebe.Location = new Point(22, 473);
            listBoxDebe.Name = "listBoxDebe";
            listBoxDebe.Size = new Size(135, 165);
            listBoxDebe.TabIndex = 9;
            listBoxDebe.UseCompatibleStateImageBehavior = false;
            // 
            // listBoxHaber
            // 
            listBoxHaber.Location = new Point(215, 473);
            listBoxHaber.Name = "listBoxHaber";
            listBoxHaber.Size = new Size(135, 165);
            listBoxHaber.TabIndex = 10;
            listBoxHaber.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(12, 98);
            label6.Name = "label6";
            label6.Size = new Size(237, 18);
            label6.TabIndex = 12;
            label6.Text = "Libro Mayor de una cuenta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Fax", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(783, 81);
            label7.Name = "label7";
            label7.Size = new Size(289, 18);
            label7.TabIndex = 13;
            label7.Text = "Libro mayor de todas las cuentas";
            // 
            // dataCuentasMayor
            // 
            dataCuentasMayor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCuentasMayor.Location = new Point(379, 81);
            dataCuentasMayor.Name = "dataCuentasMayor";
            dataCuentasMayor.RowTemplate.Height = 25;
            dataCuentasMayor.Size = new Size(371, 600);
            dataCuentasMayor.TabIndex = 14;
            dataCuentasMayor.CellClick += dataCuentasMayor_CellClick_1;
            // 
            // lblDebe
            // 
            lblDebe.AutoSize = true;
            lblDebe.Location = new Point(22, 443);
            lblDebe.Name = "lblDebe";
            lblDebe.Size = new Size(34, 15);
            lblDebe.TabIndex = 15;
            lblDebe.Text = "Debe";
            // 
            // lblHaber
            // 
            lblHaber.AutoSize = true;
            lblHaber.Location = new Point(215, 443);
            lblHaber.Name = "lblHaber";
            lblHaber.Size = new Size(39, 15);
            lblHaber.TabIndex = 16;
            lblHaber.Text = "Haber";
            // 
            // labelCuenta
            // 
            labelCuenta.AutoSize = true;
            labelCuenta.Location = new Point(153, 415);
            labelCuenta.Name = "labelCuenta";
            labelCuenta.Size = new Size(45, 15);
            labelCuenta.TabIndex = 11;
            labelCuenta.Text = "Cuenta";
            // 
            // labelTotalSaldo
            // 
            labelTotalSaldo.AutoSize = true;
            labelTotalSaldo.Location = new Point(90, 666);
            labelTotalSaldo.Name = "labelTotalSaldo";
            labelTotalSaldo.Size = new Size(67, 15);
            labelTotalSaldo.TabIndex = 17;
            labelTotalSaldo.Text = "Total Saldo:";
            // 
            // dataTodasLasCuentas
            // 
            dataTodasLasCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTodasLasCuentas.Columns.AddRange(new DataGridViewColumn[] { colCuenta, colDeudor, colAcreedor });
            dataTodasLasCuentas.Location = new Point(757, 190);
            dataTodasLasCuentas.Name = "dataTodasLasCuentas";
            dataTodasLasCuentas.RowTemplate.Height = 25;
            dataTodasLasCuentas.Size = new Size(393, 491);
            dataTodasLasCuentas.TabIndex = 18;
            // 
            // colCuenta
            // 
            colCuenta.FillWeight = 120F;
            colCuenta.HeaderText = "Cuenta";
            colCuenta.Name = "colCuenta";
            // 
            // colDeudor
            // 
            colDeudor.HeaderText = "Saldo Deudor";
            colDeudor.Name = "colDeudor";
            colDeudor.Width = 115;
            // 
            // colAcreedor
            // 
            colAcreedor.HeaderText = "Saldo Acreedor";
            colAcreedor.Name = "colAcreedor";
            colAcreedor.Width = 115;
            // 
            // FormLibroMayor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.redimMayor;
            ClientSize = new Size(1162, 710);
            Controls.Add(dataTodasLasCuentas);
            Controls.Add(labelTotalSaldo);
            Controls.Add(lblHaber);
            Controls.Add(lblDebe);
            Controls.Add(dataCuentasMayor);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(labelCuenta);
            Controls.Add(listBoxHaber);
            Controls.Add(listBoxDebe);
            Controls.Add(btnTodasCuentas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCuentaMayor);
            Controls.Add(btnEnviar);
            Controls.Add(dateTimeFechaFin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimeFechaInicio);
            Name = "FormLibroMayor";
            Text = "FormLibroMayor";
            Load += FormLibroMayor_Load;
            ((System.ComponentModel.ISupportInitialize)dataCuentasMayor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataTodasLasCuentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnEnviar;
        private Label label3;
        private Label label4;
        private Button btnTodasCuentas;
        public DateTimePicker dateTimeFechaInicio;
        public DateTimePicker dateTimeFechaFin;
        public TextBox txtCuentaMayor;
        private ListView listBoxDebe;
        private ListView listBoxHaber;
        private Label label6;
        private Label label7;
        private DataGridView dataCuentasMayor;
        private Label lblDebe;
        private Label lblHaber;
        private Label labelCuenta;
        private Label labelTotalSaldo;
        private DataGridView dataTodasLasCuentas;
        private DataGridViewTextBoxColumn colCuenta;
        private DataGridViewTextBoxColumn colDeudor;
        private DataGridViewTextBoxColumn colAcreedor;
    }
}