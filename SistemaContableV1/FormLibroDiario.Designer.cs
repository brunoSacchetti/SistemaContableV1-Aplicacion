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
            dataLibroDiario = new DataGridView();
            dataCuentas = new DataGridView();
            btnImportarCuenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataLibroDiario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataCuentas).BeginInit();
            SuspendLayout();
            // 
            // dataLibroDiario
            // 
            dataLibroDiario.BackgroundColor = SystemColors.ControlLightLight;
            dataLibroDiario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLibroDiario.GridColor = SystemColors.ButtonFace;
            dataLibroDiario.Location = new Point(12, 12);
            dataLibroDiario.Name = "dataLibroDiario";
            dataLibroDiario.RowTemplate.Height = 25;
            dataLibroDiario.Size = new Size(631, 538);
            dataLibroDiario.TabIndex = 0;
            // 
            // dataCuentas
            // 
            dataCuentas.BackgroundColor = Color.MistyRose;
            dataCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCuentas.GridColor = Color.MediumAquamarine;
            dataCuentas.Location = new Point(649, 41);
            dataCuentas.Name = "dataCuentas";
            dataCuentas.RowTemplate.Height = 25;
            dataCuentas.Size = new Size(250, 509);
            dataCuentas.TabIndex = 1;
            // 
            // btnImportarCuenta
            // 
            btnImportarCuenta.Location = new Point(649, 12);
            btnImportarCuenta.Name = "btnImportarCuenta";
            btnImportarCuenta.Size = new Size(253, 23);
            btnImportarCuenta.TabIndex = 2;
            btnImportarCuenta.Text = "Importar Cuentas";
            btnImportarCuenta.UseVisualStyleBackColor = true;
            btnImportarCuenta.Click += btnImportarCuenta_Click;
            // 
            // FormLibroDiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(914, 562);
            Controls.Add(dataCuentas);
            Controls.Add(btnImportarCuenta);
            Controls.Add(dataLibroDiario);
            Name = "FormLibroDiario";
            Text = "LibroDiario";
            ((System.ComponentModel.ISupportInitialize)dataLibroDiario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataCuentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataLibroDiario;
        private DataGridView dataCuentas;
        private Button btnImportarCuenta;
    }
}