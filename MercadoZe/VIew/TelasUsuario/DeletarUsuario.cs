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
    public partial class DeletarUsuario : Form
    {
        public DeletarUsuario()
        {
            InitializeComponent();
        }

        private void btn_BuscarUsuario_Click(object sender, EventArgs e)
        {
           
            Usuario.Id_Usuario = Convert.ToInt32(tbx_MatriculaUsuario.Text);
            manipulaUsuario manipulaUsuario = new manipulaUsuario();
            manipulaUsuario.VisualizarCodigoUsuario();

            cdx_TipoUsuario.Text = Usuario.TipoUsuario1;
            tbx_NomeUsuario.Text = Funcionario.NomeFuncionario1;
            tbx_EmailUsuario.Text = Funcionario.EmailFuncionario1;
            tbx_NumeroUsuario.Text = Usuario.Id_Usuario.ToString();
        }

        private void btn_ExcluirUsuario_Click(object sender, EventArgs e)
        {
            Usuario.Id_Usuario = Convert.ToInt32(tbx_NumeroUsuario.Text);
            manipulaUsuario manipulaUsuario = new manipulaUsuario();
            manipulaUsuario.DeletarUsuario();
            tbx_EmailUsuario.Text = "";
            tbx_MatriculaUsuario.Text = "";
            tbx_NomeUsuario.Text = "0";
            cdx_TipoUsuario.Text = "";

        }
    }
}
