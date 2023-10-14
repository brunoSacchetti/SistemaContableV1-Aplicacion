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
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Location = new Point(150, 73);
            panel.Name = "panel";
            panel.Size = new Size(1038, 602);
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
            btnRegistrarEmpresa.Location = new Point(21, 73);
            btnRegistrarEmpresa.Name = "btnRegistrarEmpresa";
            btnRegistrarEmpresa.Size = new Size(86, 63);
            btnRegistrarEmpresa.TabIndex = 1;
            btnRegistrarEmpresa.Text = "Registrar Empresa";
            btnRegistrarEmpresa.UseVisualStyleBackColor = true;
            btnRegistrarEmpresa.Click += btnRegistrarEmpresa_Click;
            // 
            // btnLibroDiario
            // 
            btnLibroDiario.Location = new Point(21, 284);
            btnLibroDiario.Name = "btnLibroDiario";
            btnLibroDiario.Size = new Size(86, 65);
            btnLibroDiario.TabIndex = 2;
            btnLibroDiario.Text = "Libro Diario";
            btnLibroDiario.UseVisualStyleBackColor = true;
            btnLibroDiario.Click += btnLibroDiario_Click;
            // 
            // btnPlanCuenta
            // 
            btnPlanCuenta.Location = new Point(21, 177);
            btnPlanCuenta.Name = "btnPlanCuenta";
            btnPlanCuenta.Size = new Size(86, 62);
            btnPlanCuenta.TabIndex = 3;
            btnPlanCuenta.Text = "Plan de Cuentas";
            btnPlanCuenta.UseVisualStyleBackColor = true;
            btnPlanCuenta.Click += btnPlanCuenta_Click;
            // 
            // btnLibroMayor
            // 
            btnLibroMayor.Location = new Point(21, 385);
            btnLibroMayor.Name = "btnLibroMayor";
            btnLibroMayor.Size = new Size(90, 65);
            btnLibroMayor.TabIndex = 4;
            btnLibroMayor.TabStop = false;
            btnLibroMayor.Text = "Libro Mayor";
            btnLibroMayor.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1200, 687);
            Controls.Add(btnLibroMayor);
            Controls.Add(btnPlanCuenta);
            Controls.Add(btnLibroDiario);
            Controls.Add(btnRegistrarEmpresa);
            Controls.Add(label1);
            Controls.Add(panel);
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