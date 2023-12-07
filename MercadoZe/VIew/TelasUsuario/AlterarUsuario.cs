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
    public partial class AlterarUsuario : Form
    {
        public AlterarUsuario()
        {
            InitializeComponent();
        }

        private void btn_CadastrarUsuario_Click(object sender, EventArgs e)
        {

            if (tbx_MatriculaAlterar.Text == "")
            {
                MessageBox.Show("Digite a Matricula do Usuário");
            }
            else {

            var resposta = MessageBox.Show("Deseja realmente alterar os registros do usuário " + tbx_nomeAlterar.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
               
                if (resposta == DialogResult.Yes)
                {
                    Usuario.Id_FuncionarioFK = Convert.ToInt32(tbx_MatriculaAlterar.Text);
                    Usuario.TipoUsuario1 = cbx_TipoAlterar.Text;
                    Usuario.SenhaUsuario1 = tbx_SenhaAlterar.Text;

                    manipulaUsuario manipula = new manipulaUsuario();
                    manipula.AlterarUsuario();

                    cbx_TipoAlterar.Text = "";
                    tbx_nomeAlterar.Text = "";
                    tbx_EmailAlterar.Text = "";
                    tbx_nomeAlterar.Text = "";
                    tbx_SenhaAlterar.Text = "";
                    tbx_MatriculaAlterar.Text = string.Empty;
                    tbx_MatriculaAlterar.Focus();
                }
                else
                {
                    cbx_TipoAlterar.Text = "";
                    tbx_nomeAlterar.Text = "";
                    tbx_EmailAlterar.Text = "";
                    tbx_nomeAlterar.Text = "";
                    tbx_SenhaAlterar.Text = "";
                    tbx_MatriculaAlterar.Text = string.Empty;
                    tbx_MatriculaAlterar.Focus();

                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario.Id_Usuario = Convert.ToInt32(tbx_MatriculaAlterar.Text);
            manipulaUsuario manipulaUsuario = new manipulaUsuario();
            manipulaUsuario.VisualizarCodigoUsuario();

            cbx_TipoAlterar.Text = Usuario.TipoUsuario1;
            tbx_nomeAlterar.Text = Funcionario.NomeFuncionario1;
            tbx_SenhaAlterar.Text = Usuario.SenhaUsuario1;
            tbx_EmailAlterar.Text = Funcionario.EmailFuncionario1;
            tbx_MatriculaAlterar.Text = Usuario.Id_Usuario.ToString();

        }
    }
}
