using MercadoZe.Controller;
using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoZe.VIew.TelasCliente
{
    public partial class PesquisarCliente : Form
    {
        public PesquisarCliente()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            cliente.Id_Cliente = Convert.ToInt32(tbx_Matricula.Text);
            manipulaCliente manipulaCliente = new manipulaCliente();
            manipulaCliente.BuscarCliente();

            tbx_Nome.Text = cliente.NomeCliente1;
            tbx_Email.Text = cliente.EmailCliente1;
            mtbx_Fone.Text = cliente.CelularCliente1.ToString();

            tbx_Matricula.Text = cliente.Id_Cliente.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.NomeCliente1 = tbx_Pesquisa.Text;
            dataGridViewUsuarios.DataSource = manipulaCliente.VisualizarNome();
            dataGridViewUsuarios.Columns[0].Visible = false;
            dataGridViewUsuarios.Columns[1].Visible = false;
            dataGridViewUsuarios.Columns[2].Visible = false;
            dataGridViewUsuarios.Columns[3].Visible = false;
            dataGridViewUsuarios.Columns[4].HeaderCell.Value = "Código";
            dataGridViewUsuarios.Columns[5].HeaderCell.Value = "Nome";
            dataGridViewUsuarios.Columns[6].HeaderCell.Value = "Email";
            dataGridViewUsuarios.Columns[7].HeaderCell.Value = "Celular";
        }
    }
}
