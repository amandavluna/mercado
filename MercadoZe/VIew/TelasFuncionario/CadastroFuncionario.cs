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

namespace MercadoZe.VIew.TelasFuncionario
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_CadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario.NomeFuncionario1 = tbx_NomeFuncionario.Text;
            Funcionario.EmailFuncionario1 = tbx_EmailFuncionario.Text;
            Funcionario.FoneFuncionario1 = mtbx_FoneFuncionario.Text;

            manipulaFuncionario manipulaFuncionario = new manipulaFuncionario();
            manipulaFuncionario.AdicionarFuncionario();
        }
    }
}
