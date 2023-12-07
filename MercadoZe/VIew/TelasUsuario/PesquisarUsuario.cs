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
    public partial class PesquisarUsuario : Form
    {
        public PesquisarUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_CadastrarBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_BuscarPesquisar_Click(object sender, EventArgs e)
        {
            Usuario.Id_Usuario = Convert.ToInt32(tbx_MatriculaPesquisa.Text);
            manipulaUsuario manipulaUsuario = new manipulaUsuario();
            manipulaUsuario.VisualizarCodigoUsuario();

            cbx_TipoPesquisa.Text = Usuario.TipoUsuario1;
            tbx_NomePessquisar.Text = Funcionario.NomeFuncionario1;
            tbx_Email.Text = Funcionario.EmailFuncionario1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario.TipoUsuario1 = cbx_TipoPesquisa.Text;
            dataGridViewUsuarios.DataSource = manipulaUsuario.VisualizarTipoUsuario();
            dataGridViewUsuarios.Columns[0].Visible = false;
            dataGridViewUsuarios.Columns[1].Visible = false;
            dataGridViewUsuarios.Columns[2].Visible = false;
            dataGridViewUsuarios.Columns[3].HeaderCell.Value = "Código do Usuário";
            dataGridViewUsuarios.Columns[4].HeaderCell.Value = "Função";
            dataGridViewUsuarios.Columns[5].HeaderCell.Value = "Data Acesso";
            dataGridViewUsuarios.Columns[6].HeaderCell.Value = "Matricula Funcionário";
            dataGridViewUsuarios.Columns[7].Visible = false;
        }
    }
}
