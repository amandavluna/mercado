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

namespace MercadoZe.VIew.TelasUsuario
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            Funcionario.Id_Funcionario = Convert.ToInt32(tbx_MatriculaFuncionario.Text);
            Usuario.SenhaUsuario1 = tbx_SenhaUsuario.Text;
            Usuario.TipoUsuario1 = cbx_TipoUsuario.Text;
            manipulaUsuario manipulaUsuario = new manipulaUsuario();
            manipulaUsuario.CadastrarUsuario();

           


            
        }

        private void btn_BuscarUsuario_Click(object sender, EventArgs e)
        {
            Funcionario.Id_Funcionario = Convert.ToInt32(tbx_MatriculaFuncionario.Text);
            manipulaFuncionario manipulaFuncionario = new manipulaFuncionario();
            manipulaFuncionario.BuscarFuncionario();


            tbx_EmailUsuario.Text = Funcionario.EmailFuncionario1;
            tbx_NomeUsuario.Text = Funcionario.NomeFuncionario1;
         

        }
    }
}
