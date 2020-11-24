using EjercicioClientes2.Entidades;
using EjercicioClientes2.Entidades.Exceptions;
using EjercicioClientes2.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClientes2
{
    public partial class FrmCuentas : Form
    {
        private CuentaServicio _cuentaServicio;
        private ClienteServicio _clienteServicio;

        public FrmCuentas()
        {
            this._clienteServicio = new ClienteServicio();
            this._cuentaServicio = new CuentaServicio();
            InitializeComponent();
        }

        public void CargarComboCliente(List<Cliente> clientes)
        {
            cboxClientes.DataSource = null;
            cboxClientes.DataSource = clientes;
        }



        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            CargarComboCliente(_clienteServicio.TraerClientes());
            //CargarListaDeCuentas();
        }

        private void FrmCuentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void cboxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                Cliente cliente = (Cliente)cboxClientes.SelectedItem;

                int idCliente = cliente.ID;

                lstCuentas.DataSource = null;
                lstCuentas.DataSource = _cuentaServicio.TraerCuentas(idCliente);

            }
            catch (ElClienteNoTieneCuentasException ex1)
            {
                MessageBox.Show(ex1.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
