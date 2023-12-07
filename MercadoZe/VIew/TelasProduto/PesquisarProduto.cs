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

namespace MercadoZe.VIew.TelasProduto
{
    public partial class PesquisarProduto : Form
    {
        public PesquisarProduto()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Produto.Id_Produto = Convert.ToInt32(tbx_Matricula.Text);
            manipulaProduto manipulaProduto = new manipulaProduto();
            manipulaProduto.BuscarProduto();

            tbx_Marca.Text = Produto.MarcaProduto1;
            tbx_Nome.Text = Produto.NomeProduto1;
            tbx_Valor.Text = Produto.ValorProduto1.ToString();

            tbx_Matricula.Text = Produto.Id_Produto.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto.NomeProduto1 = tbx_Pesquisa.Text;
            dataGridViewUsuarios.DataSource = manipulaProduto.VisualizarID1();
            dataGridViewUsuarios.Columns[0].Visible = false;
            dataGridViewUsuarios.Columns[1].Visible = false;
            dataGridViewUsuarios.Columns[2].Visible = false;
            dataGridViewUsuarios.Columns[3].Visible = false;
            dataGridViewUsuarios.Columns[4].HeaderCell.Value = "Código";
            dataGridViewUsuarios.Columns[5].HeaderCell.Value = "Nome";
            dataGridViewUsuarios.Columns[6].HeaderCell.Value = "Email";
            dataGridViewUsuarios.Columns[7].HeaderCell.Value = "Fone";
        }
    }
}
