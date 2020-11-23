using EjercicioClientes2.Entidades;
using EjercicioClientes2.Entidades.Exceptions;
using EjercicioClientes2.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClientes2
{
    public partial class FrmClientes : Form
    {
        private ClienteServicio _clienteServicio;
        public FrmClientes()
        {
            this._clienteServicio = new ClienteServicio();
            InitializeComponent();
        }

        //MÉTODOS

        public void CargarClientes(List<Cliente> clientes)
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = clientes;
        }

        public void ValidarCamposVaciosCliente()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)    ||
                string.IsNullOrWhiteSpace(txtApellido.Text)  ||
                string.IsNullOrWhiteSpace(txtDNI.Text)       ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text)     ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                throw new CamposVaciosClienteException();
            }
        }
        public void BlanquearCampos()
        {

            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            
        }

        //EVENTOS
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes(_clienteServicio.TraerClientes());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCamposVaciosCliente();

                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                long dni = long.Parse(txtDNI.Text);
                string direccion = txtDireccion.Text;
                long telefono = long.Parse(txtTelefono.Text);
                string email = txtEmail.Text;
                DateTime nacimiento = dateTimePickerFN.Value;
                bool activo = ckbActivo.Checked;
                int id = this._clienteServicio.ProximoId();

                Cliente cliente = new Cliente(nombre, apellido, dni, direccion, email, telefono, nacimiento, activo, id);

                _clienteServicio.AgregarCliente(cliente);

                MessageBox.Show("Cliente agregado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarClientes(_clienteServicio.TraerClientes());

                BlanquearCampos();

            }
            catch (CamposVaciosClienteException ex1)
            {
                MessageBox.Show(ex1.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BlanquearCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BlanquearCampos();
            }
        }

        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
