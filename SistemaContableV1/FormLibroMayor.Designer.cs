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
            btnMayorUnaCuenta = new Button();
            txtCuentaMayor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // dateTimeFechaInicio
            // 
            dateTimeFechaInicio.Location = new Point(12, 127);
            dateTimeFechaInicio.Name = "dateTimeFechaInicio";
            dateTimeFechaInicio.Size = new Size(212, 23);
            dateTimeFechaInicio.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 96);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 96);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha Fin";
            // 
            // dateTimeFechaFin
            // 
            dateTimeFechaFin.Location = new Point(247, 127);
            dateTimeFechaFin.Name = "dateTimeFechaFin";
            dateTimeFechaFin.Size = new Size(215, 23);
            dateTimeFechaFin.TabIndex = 3;
            // 
            // btnMayorUnaCuenta
            // 
            btnMayorUnaCuenta.Location = new Point(714, 114);
            btnMayorUnaCuenta.Name = "btnMayorUnaCuenta";
            btnMayorUnaCuenta.Size = new Size(120, 53);
            btnMayorUnaCuenta.TabIndex = 4;
            btnMayorUnaCuenta.Text = "Consultar Libro Mayor";
            btnMayorUnaCuenta.UseVisualStyleBackColor = true;
            btnMayorUnaCuenta.Click += btnMayorUnaCuenta_Click;
            // 
            // txtCuentaMayor
            // 
            txtCuentaMayor.Location = new Point(487, 130);
            txtCuentaMayor.Name = "txtCuentaMayor";
            txtCuentaMayor.Size = new Size(196, 23);
            txtCuentaMayor.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(529, 98);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre de la Cuenta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(305, 9);
            label4.Name = "label4";
            label4.Size = new Size(184, 37);
            label4.TabIndex = 7;
            label4.Text = "LIBRO MAYOR";
            // 
            // FormLibroMayor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCuentaMayor);
            Controls.Add(btnMayorUnaCuenta);
            Controls.Add(dateTimeFechaFin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimeFechaInicio);
            Name = "FormLibroMayor";
            Text = "FormLibroMayor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimeFechaInicio;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimeFechaFin;
        private Button btnMayorUnaCuenta;
        private TextBox txtCuentaMayor;
        private Label label3;
        private Label label4;
    }
}