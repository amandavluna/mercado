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
    public partial class DeletarCliente : Form
    {
        public DeletarCliente()
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

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            cliente.Id_Cliente = Convert.ToInt32(tbx_Matricula.Text);
            manipulaCliente manipulaCliente = new manipulaCliente();
            manipulaCliente.DeletarCliente();

            tbx_Matricula.Text = "";
            mtbx_Fone.Text = "0";
            tbx_Email.Text = "";
            tbx_Nome.Text = "";
        }
    }
}
