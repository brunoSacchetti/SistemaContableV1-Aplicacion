namespace SistemaContableV1
{
    partial class RegistroEmpresa
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
            btnNombre = new Button();
            btnTelefono = new Button();
            btnCiudad = new Button();
            btnEmail = new Button();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCiudad = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            btnGuardar = new Button();
            btnModificar = new Button();
            Eliminar = new Button();
            dataGridViewEmpresas = new DataGridView();
            nombreEmpresa = new DataGridViewTextBoxColumn();
            ciudadEmpresa = new DataGridViewTextBoxColumn();
            telEmpresa = new DataGridViewTextBoxColumn();
            emailEmpresa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpresas).BeginInit();
            SuspendLayout();
            // 
            // btnNombre
            // 
            btnNombre.Location = new Point(36, 91);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(75, 23);
            btnNombre.TabIndex = 0;
            btnNombre.Text = "Nombre";
            btnNombre.UseVisualStyleBackColor = true;
            // 
            // btnTelefono
            // 
            btnTelefono.Location = new Point(395, 92);
            btnTelefono.Name = "btnTelefono";
            btnTelefono.Size = new Size(75, 23);
            btnTelefono.TabIndex = 1;
            btnTelefono.Text = "Telefono";
            btnTelefono.UseVisualStyleBackColor = true;
            // 
            // btnCiudad
            // 
            btnCiudad.Location = new Point(36, 142);
            btnCiudad.Name = "btnCiudad";
            btnCiudad.Size = new Size(75, 23);
            btnCiudad.TabIndex = 2;
            btnCiudad.Text = "Ciudad";
            btnCiudad.UseVisualStyleBackColor = true;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(395, 140);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(75, 23);
            btnEmail.TabIndex = 3;
            btnEmail.Text = "Email";
            btnEmail.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(138, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(491, 92);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(239, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(138, 142);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(227, 23);
            txtCiudad.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(491, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 23);
            txtEmail.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(273, 25);
            label1.Name = "label1";
            label1.Size = new Size(277, 34);
            label1.TabIndex = 8;
            label1.Text = "Registro de Empresa";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(138, 216);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(359, 216);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(144, 23);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(586, 216);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(144, 23);
            Eliminar.TabIndex = 11;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // dataGridViewEmpresas
            // 
            dataGridViewEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpresas.Columns.AddRange(new DataGridViewColumn[] { nombreEmpresa, ciudadEmpresa, telEmpresa, emailEmpresa });
            dataGridViewEmpresas.Location = new Point(36, 261);
            dataGridViewEmpresas.Name = "dataGridViewEmpresas";
            dataGridViewEmpresas.RowTemplate.Height = 25;
            dataGridViewEmpresas.Size = new Size(752, 299);
            dataGridViewEmpresas.TabIndex = 12;
            dataGridViewEmpresas.CellClick += dataGridViewEmpresas_CellClick;
            // 
            // nombreEmpresa
            // 
            nombreEmpresa.HeaderText = "Nombre";
            nombreEmpresa.Name = "nombreEmpresa";
            // 
            // ciudadEmpresa
            // 
            ciudadEmpresa.HeaderText = "Ciudad";
            ciudadEmpresa.Name = "ciudadEmpresa";
            // 
            // telEmpresa
            // 
            telEmpresa.HeaderText = "Telefono";
            telEmpresa.Name = "telEmpresa";
            telEmpresa.Width = 200;
            // 
            // emailEmpresa
            // 
            emailEmpresa.HeaderText = "Email";
            emailEmpresa.Name = "emailEmpresa";
            emailEmpresa.Width = 300;
            // 
            // RegistroEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 572);
            Controls.Add(dataGridViewEmpresas);
            Controls.Add(Eliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtCiudad);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(btnEmail);
            Controls.Add(btnCiudad);
            Controls.Add(btnTelefono);
            Controls.Add(btnNombre);
            Name = "RegistroEmpresa";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpresas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNombre;
        private Button btnTelefono;
        private Button btnCiudad;
        private Button btnEmail;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCiudad;
        private TextBox txtEmail;
        private Label label1;
        private Button btnGuardar;
        private Button btnModificar;
        private Button Eliminar;
        private DataGridView dataGridViewEmpresas;
        private DataGridViewTextBoxColumn nombreEmpresa;
        private DataGridViewTextBoxColumn ciudadEmpresa;
        private DataGridViewTextBoxColumn telEmpresa;
        private DataGridViewTextBoxColumn emailEmpresa;
    }
}