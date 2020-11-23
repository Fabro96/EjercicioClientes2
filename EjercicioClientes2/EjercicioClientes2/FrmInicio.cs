using System;
using EjercicioClientes2.Entidades;
using EjercicioClientes2.Negocio;
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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClientes FrmClientes = new FrmClientes();
            FrmClientes.Owner = this;
            FrmClientes.Show();
            this.Hide();
        }

    }
}
