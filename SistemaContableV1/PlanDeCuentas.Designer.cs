namespace SistemaContableV1
{
    partial class PlanDeCuentas

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
            label1 = new Label();
            dataGridViewPlanCuentas = new DataGridView();
            IdCuenta = new DataGridViewTextBoxColumn();
            Rubro = new DataGridViewTextBoxColumn();
            NumeroCuenta = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txtRubro = new TextBox();
            txtNumeroCuenta = new TextBox();
            txtDescripcion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnImprimir = new Button();
            txtId = new Label();
            textId = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlanCuentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(281, 26);
            label1.Name = "label1";
            label1.Size = new Size(261, 34);
            label1.TabIndex = 0;
            label1.Text = "PLAN DE CUENTAS";
            // 
            // dataGridViewPlanCuentas
            // 
            dataGridViewPlanCuentas.BackgroundColor = SystemColors.AppWorkspace;
            dataGridViewPlanCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlanCuentas.Columns.AddRange(new DataGridViewColumn[] { IdCuenta, Rubro, NumeroCuenta, Descripcion });
            dataGridViewPlanCuentas.Location = new Point(122, 63);
            dataGridViewPlanCuentas.Name = "dataGridViewPlanCuentas";
            dataGridViewPlanCuentas.RowTemplate.Height = 25;
            dataGridViewPlanCuentas.Size = new Size(543, 385);
            dataGridViewPlanCuentas.TabIndex = 1;
            // 
            // IdCuenta
            // 
            IdCuenta.HeaderText = "Id";
            IdCuenta.Name = "IdCuenta";
            // 
            // Rubro
            // 
            Rubro.HeaderText = "Rubro";
            Rubro.Name = "Rubro";
            // 
            // NumeroCuenta
            // 
            NumeroCuenta.HeaderText = "Numero De Cuenta";
            NumeroCuenta.Name = "NumeroCuenta";
            NumeroCuenta.Width = 150;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 464);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Rubro";
            // 
            // txtRubro
            // 
            txtRubro.Location = new Point(268, 482);
            txtRubro.Name = "txtRubro";
            txtRubro.Size = new Size(100, 23);
            txtRubro.TabIndex = 3;
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Location = new Point(413, 482);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(100, 23);
            txtNumeroCuenta.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(565, 482);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(431, 464);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 6;
            label3.Text = "NroCuenta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(583, 461);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Descripcion";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(132, 517);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(281, 517);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(421, 517);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(577, 517);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 11;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(0, 0);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // textId
            // 
            textId.Location = new Point(122, 482);
            textId.Name = "textId";
            textId.Size = new Size(100, 23);
            textId.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 464);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 13;
            label5.Text = "Id";
            // 
            // PlanDeCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(892, 663);
            Controls.Add(label5);
            Controls.Add(textId);
            Controls.Add(btnImprimir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(txtRubro);
            Controls.Add(label2);
            Controls.Add(dataGridViewPlanCuentas);
            Controls.Add(label1);
            Name = "PlanDeCuentas";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlanCuentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewPlanCuentas;
        private Label label2;
        private TextBox txtRubro;
        private TextBox txtNumeroCuenta;
        private TextBox txtDescripcion;
        private Label label3;
        private Label label4;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnImprimir;
        private DataGridViewTextBoxColumn IdCuenta;
        private DataGridViewTextBoxColumn Rubro;
        private DataGridViewTextBoxColumn NumeroCuenta;
        private DataGridViewTextBoxColumn Descripcion;
        private Label txtId;
        private TextBox textId;
        private Label label5;
    }
}