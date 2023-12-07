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
    public partial class PesquisarFuncionario : Form
    {
        public PesquisarFuncionario()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Funcionario.Id_Funcionario = Convert.ToInt32(tbx_Matricula.Text);
            manipulaFuncionario manipulaFuncionario = new manipulaFuncionario();
            manipulaFuncionario.BuscarFuncionario();

            tbx_Nome.Text = Funcionario.NomeFuncionario1;
            tbx_Email.Text = Funcionario.EmailFuncionario1;
            mtbx_Fone.Text = Funcionario.FoneFuncionario1.ToString();

            tbx_Matricula.Text = Funcionario.Id_Funcionario.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario.NomeFuncionario1 = tbx_Pesquisa.Text;
            dataGridView.DataSource = manipulaFuncionario.VisualizarNome();
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[2].Visible = false;
            dataGridView.Columns[3].Visible = false;
            dataGridView.Columns[4].HeaderCell.Value = "Código";
            dataGridView.Columns[5].HeaderCell.Value = "Nome";
            dataGridView.Columns[6].HeaderCell.Value = "Fone";
            dataGridView.Columns[7].HeaderCell.Value = "Email";
        }
    }
}
