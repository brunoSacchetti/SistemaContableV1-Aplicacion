namespace SistemaContableV1
{
    partial class FormLibroDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibroDiario));
            dataLibroDiario = new DataGridView();
            cod = new DataGridViewTextBoxColumn();
            cuentas = new DataGridViewTextBoxColumn();
            debe = new DataGridViewTextBoxColumn();
            haber = new DataGridViewTextBoxColumn();
            dataCuentas = new DataGridView();
            btnImportarCuenta = new Button();
            btnEliminaCuenta = new Button();
            btnGuardarAsiento = new Button();
            btnLibroMayor = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            dateAsiento = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataLibroDiario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataCuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataLibroDiario
            // 
            dataLibroDiario.AllowUserToAddRows = false;
            dataLibroDiario.BackgroundColor = SystemColors.ControlLightLight;
            dataLibroDiario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLibroDiario.Columns.AddRange(new DataGridViewColumn[] { cod, cuentas, debe, haber });
            dataLibroDiario.GridColor = SystemColors.ButtonFace;
            dataLibroDiario.Location = new Point(12, 19);
            dataLibroDiario.Name = "dataLibroDiario";
            dataLibroDiario.RowTemplate.Height = 25;
            dataLibroDiario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataLibroDiario.Size = new Size(631, 538);
            dataLibroDiario.TabIndex = 0;
            // 
            // cod
            // 
            cod.HeaderText = "Codigo";
            cod.Name = "cod";
            // 
            // cuentas
            // 
            cuentas.HeaderText = "Cuentas";
            cuentas.Name = "cuentas";
            cuentas.Width = 240;
            // 
            // debe
            // 
            debe.HeaderText = "Debe";
            debe.Name = "debe";
            debe.Width = 120;
            // 
            // haber
            // 
            haber.HeaderText = "Haber";
            haber.Name = "haber";
            haber.Width = 120;
            // 
            // dataCuentas
            // 
            dataCuentas.BackgroundColor = Color.MistyRose;
            dataCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCuentas.GridColor = Color.MediumAquamarine;
            dataCuentas.Location = new Point(649, 41);
            dataCuentas.Name = "dataCuentas";
            dataCuentas.ReadOnly = true;
            dataCuentas.RowTemplate.Height = 25;
            dataCuentas.Size = new Size(394, 509);
            dataCuentas.TabIndex = 1;
            dataCuentas.CellClick += dataCuentas_CellClick;
            dataCuentas.CellDoubleClick += dataCuentas_CellDoubleClick;
            // 
            // btnImportarCuenta
            // 
            btnImportarCuenta.Location = new Point(711, 12);
            btnImportarCuenta.Name = "btnImportarCuenta";
            btnImportarCuenta.Size = new Size(301, 23);
            btnImportarCuenta.TabIndex = 2;
            btnImportarCuenta.Text = "Importar Cuentas";
            btnImportarCuenta.UseVisualStyleBackColor = true;
            btnImportarCuenta.Click += btnImportarCuenta_Click;
            // 
            // btnEliminaCuenta
            // 
            btnEliminaCuenta.Location = new Point(62, 647);
            btnEliminaCuenta.Name = "btnEliminaCuenta";
            btnEliminaCuenta.Size = new Size(181, 23);
            btnEliminaCuenta.TabIndex = 3;
            btnEliminaCuenta.Text = "Eliminar Cuenta del Asiento";
            btnEliminaCuenta.UseVisualStyleBackColor = true;
            btnEliminaCuenta.Click += btnEliminaCuenta_Click;
            // 
            // btnGuardarAsiento
            // 
            btnGuardarAsiento.Location = new Point(277, 636);
            btnGuardarAsiento.Name = "btnGuardarAsiento";
            btnGuardarAsiento.Size = new Size(155, 45);
            btnGuardarAsiento.TabIndex = 4;
            btnGuardarAsiento.Text = "Guardar Asiento";
            btnGuardarAsiento.UseVisualStyleBackColor = true;
            btnGuardarAsiento.Click += btnGuardarAsiento_Click;
            // 
            // btnLibroMayor
            // 
            btnLibroMayor.Location = new Point(863, 611);
            btnLibroMayor.Name = "btnLibroMayor";
            btnLibroMayor.Size = new Size(101, 34);
            btnLibroMayor.TabIndex = 5;
            btnLibroMayor.Text = "Libro Mayor";
            btnLibroMayor.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(377, 813);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(519, 618);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(740, 618);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(726, 677);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(286, 191);
            dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(44, 565);
            label1.Name = "label1";
            label1.Size = new Size(163, 24);
            label1.TabIndex = 11;
            label1.Text = "Fecha del Asiento";
            // 
            // dateAsiento
            // 
            dateAsiento.Location = new Point(232, 565);
            dateAsiento.Name = "dateAsiento";
            dateAsiento.Size = new Size(216, 23);
            dateAsiento.TabIndex = 12;
            // 
            // FormLibroDiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1055, 906);
            Controls.Add(dateAsiento);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnLibroMayor);
            Controls.Add(btnGuardarAsiento);
            Controls.Add(btnEliminaCuenta);
            Controls.Add(dataCuentas);
            Controls.Add(btnImportarCuenta);
            Controls.Add(dataLibroDiario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLibroDiario";
            Text = "LibroDiario";
            Load += FormLibroDiario_Load;
            ((System.ComponentModel.ISupportInitialize)dataLibroDiario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataCuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataLibroDiario;
        private DataGridView dataCuentas;
        private Button btnImportarCuenta;
        private DataGridViewTextBoxColumn cod;
        private DataGridViewTextBoxColumn cuentas;
        private DataGridViewTextBoxColumn debe;
        private DataGridViewTextBoxColumn haber;
        private Button btnEliminaCuenta;
        private Button btnGuardarAsiento;
        public Button btnLibroMayor;
        public DateTimePicker dateTimePicker1;
        public DateTimePicker dateTimePicker2;
        public TextBox textBox1;
        public DataGridView dataGridView1;
        private Label label1;
        private DateTimePicker dateAsiento;
    }
}