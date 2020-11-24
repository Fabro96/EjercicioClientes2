namespace EjercicioClientes2
{
    partial class FrmCuentas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAltaCuenta = new System.Windows.Forms.Label();
            this.lblListaCuentas = new System.Windows.Forms.Label();
            this.cboxClientes = new System.Windows.Forms.ComboBox();
            this.lstCuentas = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboxClientes);
            this.panel1.Controls.Add(this.lblAltaCuenta);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 496);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstCuentas);
            this.panel2.Controls.Add(this.lblListaCuentas);
            this.panel2.Location = new System.Drawing.Point(490, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 496);
            this.panel2.TabIndex = 1;
            // 
            // lblAltaCuenta
            // 
            this.lblAltaCuenta.AutoSize = true;
            this.lblAltaCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaCuenta.Location = new System.Drawing.Point(13, 13);
            this.lblAltaCuenta.Name = "lblAltaCuenta";
            this.lblAltaCuenta.Size = new System.Drawing.Size(213, 25);
            this.lblAltaCuenta.TabIndex = 0;
            this.lblAltaCuenta.Text = "ALTA DE CUENTAS";
            // 
            // lblListaCuentas
            // 
            this.lblListaCuentas.AutoSize = true;
            this.lblListaCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCuentas.Location = new System.Drawing.Point(13, 13);
            this.lblListaCuentas.Name = "lblListaCuentas";
            this.lblListaCuentas.Size = new System.Drawing.Size(219, 25);
            this.lblListaCuentas.TabIndex = 1;
            this.lblListaCuentas.Text = "LISTA DE CUENTAS";
            // 
            // cboxClientes
            // 
            this.cboxClientes.FormattingEnabled = true;
            this.cboxClientes.Location = new System.Drawing.Point(18, 63);
            this.cboxClientes.Name = "cboxClientes";
            this.cboxClientes.Size = new System.Drawing.Size(409, 24);
            this.cboxClientes.TabIndex = 0;
            this.cboxClientes.SelectedIndexChanged += new System.EventHandler(this.cboxClientes_SelectedIndexChanged);
            // 
            // lstCuentas
            // 
            this.lstCuentas.FormattingEnabled = true;
            this.lstCuentas.ItemHeight = 16;
            this.lstCuentas.Location = new System.Drawing.Point(18, 63);
            this.lstCuentas.Name = "lstCuentas";
            this.lstCuentas.Size = new System.Drawing.Size(337, 420);
            this.lstCuentas.TabIndex = 2;
            // 
            // FrmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCuentas";
            this.Text = "FrmCuentascs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCuentas_FormClosing);
            this.Load += new System.EventHandler(this.FrmCuentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxClientes;
        private System.Windows.Forms.Label lblAltaCuenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstCuentas;
        private System.Windows.Forms.Label lblListaCuentas;
    }
}