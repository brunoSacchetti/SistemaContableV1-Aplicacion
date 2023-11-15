namespace SistemaContableV1
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel = new Panel();
            label1 = new Label();
            btnRegistrarEmpresa = new Button();
            btnLibroDiario = new Button();
            btnPlanCuenta = new Button();
            btnLibroMayor = new Button();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.BackColor = SystemColors.ActiveBorder;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Location = new Point(150, 73);
            panel.Name = "panel";
            panel.Size = new Size(1068, 733);
            panel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(516, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 35);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA CONTABLE";
            // 
            // btnRegistrarEmpresa
            // 
            btnRegistrarEmpresa.BackColor = Color.LightBlue;
            btnRegistrarEmpresa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarEmpresa.ForeColor = Color.Black;
            btnRegistrarEmpresa.Location = new Point(16, 73);
            btnRegistrarEmpresa.Name = "btnRegistrarEmpresa";
            btnRegistrarEmpresa.Size = new Size(119, 74);
            btnRegistrarEmpresa.TabIndex = 1;
            btnRegistrarEmpresa.Text = "Registrar Empresa";
            btnRegistrarEmpresa.UseVisualStyleBackColor = false;
            btnRegistrarEmpresa.Click += btnRegistrarEmpresa_Click;
            // 
            // btnLibroDiario
            // 
            btnLibroDiario.BackColor = Color.LightBlue;
            btnLibroDiario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLibroDiario.ForeColor = Color.Black;
            btnLibroDiario.Location = new Point(16, 413);
            btnLibroDiario.Name = "btnLibroDiario";
            btnLibroDiario.Size = new Size(119, 70);
            btnLibroDiario.TabIndex = 2;
            btnLibroDiario.Text = "Libro Diario";
            btnLibroDiario.UseVisualStyleBackColor = false;
            btnLibroDiario.Click += btnLibroDiario_Click;
            // 
            // btnPlanCuenta
            // 
            btnPlanCuenta.BackColor = Color.LightBlue;
            btnPlanCuenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlanCuenta.ForeColor = Color.Black;
            btnPlanCuenta.Location = new Point(16, 245);
            btnPlanCuenta.Name = "btnPlanCuenta";
            btnPlanCuenta.Size = new Size(119, 79);
            btnPlanCuenta.TabIndex = 3;
            btnPlanCuenta.Text = "Plan de Cuentas";
            btnPlanCuenta.UseVisualStyleBackColor = false;
            btnPlanCuenta.Click += btnPlanCuenta_Click;
            // 
            // btnLibroMayor
            // 
            btnLibroMayor.BackColor = Color.LightBlue;
            btnLibroMayor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLibroMayor.ForeColor = Color.Black;
            btnLibroMayor.Location = new Point(16, 568);
            btnLibroMayor.Name = "btnLibroMayor";
            btnLibroMayor.Size = new Size(119, 70);
            btnLibroMayor.TabIndex = 4;
            btnLibroMayor.TabStop = false;
            btnLibroMayor.Text = "Libro Mayor";
            btnLibroMayor.UseVisualStyleBackColor = false;
            btnLibroMayor.Click += btnLibroMayor_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1230, 818);
            Controls.Add(btnLibroMayor);
            Controls.Add(btnPlanCuenta);
            Controls.Add(btnLibroDiario);
            Controls.Add(btnRegistrarEmpresa);
            Controls.Add(label1);
            Controls.Add(panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Sistema Contable";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Label label1;
        private Button btnRegistrarEmpresa;
        private Button btnLibroDiario;
        private Button btnPlanCuenta;
        private Button btnLibroMayor;
    }
}