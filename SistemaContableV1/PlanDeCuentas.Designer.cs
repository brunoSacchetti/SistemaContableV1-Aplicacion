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
            label2 = new Label();
            txtRubro = new TextBox();
            txtCuenta = new TextBox();
            label3 = new Label();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnImprimir = new Button();
            txtId = new Label();
            dPlanCuentas = new DataGridView();
            id = new Label();
            txtIde = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dPlanCuentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(175, 17);
            label1.Name = "label1";
            label1.Size = new Size(261, 34);
            label1.TabIndex = 0;
            label1.Text = "PLAN DE CUENTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 471);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Rubro";
            // 
            // txtRubro
            // 
            txtRubro.Location = new Point(180, 489);
            txtRubro.Name = "txtRubro";
            txtRubro.Size = new Size(144, 23);
            txtRubro.TabIndex = 3;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(330, 489);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(163, 23);
            txtCuenta.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 471);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "Cuenta";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(499, 489);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(210, 532);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(294, 532);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(375, 532);
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
            // dPlanCuentas
            // 
            dPlanCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dPlanCuentas.Location = new Point(106, 68);
            dPlanCuentas.Name = "dPlanCuentas";
            dPlanCuentas.RowTemplate.Height = 25;
            dPlanCuentas.Size = new Size(394, 386);
            dPlanCuentas.TabIndex = 15;
            dPlanCuentas.CellMouseClick += dPlanCuentas_CellMouseClick;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(90, 471);
            id.Name = "id";
            id.Size = new Size(18, 15);
            id.TabIndex = 16;
            id.Text = "ID";
            // 
            // txtIde
            // 
            txtIde.Location = new Point(90, 489);
            txtIde.Name = "txtIde";
            txtIde.Size = new Size(74, 23);
            txtIde.TabIndex = 17;
            // 
            // PlanDeCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(765, 571);
            Controls.Add(txtIde);
            Controls.Add(id);
            Controls.Add(dPlanCuentas);
            Controls.Add(btnImprimir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(txtCuenta);
            Controls.Add(txtRubro);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PlanDeCuentas";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dPlanCuentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRubro;
        private TextBox txtCuenta;
        private Label label3;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnImprimir;
        private Label txtId;
        private DataGridView dPlanCuentas;
        private Label id;
        private TextBox txtIde;
    }
}