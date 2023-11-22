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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            cliente.NomeCliente1 = tbx_NomeCliente.Text;
            cliente.EmailCliente1 = tbx_EmailCliente.Text;
            cliente.CelularCliente1 = mtbx_CelularCliente.Text;

            manipulaCliente manipulaCliente = new manipulaCliente();
            manipulaCliente.AdicionarCliente();

        }
    }
}
