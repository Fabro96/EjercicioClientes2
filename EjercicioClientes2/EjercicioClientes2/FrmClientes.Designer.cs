namespace EjercicioClientes2
{
    partial class FrmClientes
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
            this.lblAltaCliente = new System.Windows.Forms.Label();
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerFN = new System.Windows.Forms.DateTimePicker();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbActivo);
            this.panel1.Controls.Add(this.dateTimePickerFN);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtDNI);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblActivo);
            this.panel1.Controls.Add(this.lblFechaNac);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.lblDNI);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblAltaCliente);
            this.panel1.Location = new System.Drawing.Point(24, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 498);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstClientes);
            this.panel2.Controls.Add(this.lblListaClientes);
            this.panel2.Location = new System.Drawing.Point(457, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 498);
            this.panel2.TabIndex = 1;
            // 
            // lblAltaCliente
            // 
            this.lblAltaCliente.AutoSize = true;
            this.lblAltaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaCliente.Location = new System.Drawing.Point(19, 15);
            this.lblAltaCliente.Name = "lblAltaCliente";
            this.lblAltaCliente.Size = new System.Drawing.Size(165, 25);
            this.lblAltaCliente.TabIndex = 0;
            this.lblAltaCliente.Text = "ALTA CLIENTE";
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaClientes.Location = new System.Drawing.Point(25, 15);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(221, 25);
            this.lblListaClientes.TabIndex = 1;
            this.lblListaClientes.Text = "LISTA DE CLIENTES";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(24, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(24, 120);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(82, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(24, 170);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(68, 20);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "D.N.I.: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(24, 220);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(96, 20);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(24, 270);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(93, 20);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(24, 320);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email: ";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(24, 370);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(166, 20);
            this.lblFechaNac.TabIndex = 7;
            this.lblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(24, 420);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(61, 20);
            this.lblActivo.TabIndex = 8;
            this.lblActivo.Text = "Activo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(196, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(196, 113);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(188, 27);
            this.txtApellido.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(196, 163);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(188, 27);
            this.txtDNI.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(196, 213);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(188, 27);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(196, 263);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(188, 27);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(196, 313);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // dateTimePickerFN
            // 
            this.dateTimePickerFN.Location = new System.Drawing.Point(196, 367);
            this.dateTimePickerFN.Name = "dateTimePickerFN";
            this.dateTimePickerFN.Size = new System.Drawing.Size(188, 22);
            this.dateTimePickerFN.TabIndex = 6;
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Location = new System.Drawing.Point(196, 418);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(18, 17);
            this.ckbActivo.TabIndex = 7;
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 16;
            this.lstClientes.Location = new System.Drawing.Point(30, 63);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(350, 436);
            this.lstClientes.TabIndex = 9;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 548);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFN;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAltaCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label lblListaClientes;
    }
}