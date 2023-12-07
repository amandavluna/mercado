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
    public partial class AlterarProduto : Form
    {
        public AlterarProduto()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Produto.Id_Produto = Convert.ToInt32(tbx_MatriculaProduto.Text);
            manipulaProduto manipulaProduto1 = new manipulaProduto();
            manipulaProduto.VisualizarID();

            tbx_Nome.Text = Produto.NomeProduto1;
            tbx_Valor.Text = Produto.ValorProduto1.ToString();
            tbx_Marca.Text = Produto.MarcaProduto1;

            tbx_MatriculaProduto.Text = Produto.Id_Produto.ToString();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (tbx_MatriculaProduto.Text == "")
            {
                MessageBox.Show("Digite a Matricula do Produto");
            }
            else
            {

                var resposta = MessageBox.Show("Deseja realmente alterar os registros do usuário " + tbx_Nome.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Produto.Id_Produto = Convert.ToInt32(tbx_MatriculaProduto.Text);
                    Produto.NomeProduto1 = tbx_Nome.Text;
                    Produto.MarcaProduto1 = tbx_Marca.Text;
                    Produto.ValorProduto1 = Convert.ToInt32(tbx_Valor.Text);

                    manipulaProduto manipula = new manipulaProduto();
                    manipula.AlterarProduto();

                    tbx_Marca.Text = "";
                    tbx_Nome.Text = "";
                    tbx_Valor.Text = "";
                    tbx_MatriculaProduto.Text = string.Empty;
                    tbx_MatriculaProduto.Focus();
                }
                else
                {
                    tbx_Marca.Text = "";
                    tbx_Nome.Text = "";
                    tbx_Valor.Text = "";
                    tbx_MatriculaProduto.Text = string.Empty;
                    tbx_MatriculaProduto.Focus();

                }
            }

        }

        private void btn_Buscar1_Click(object sender, EventArgs e)
        {
            Produto.Id_Produto = Convert.ToInt32(tbx_MatriculaProduto.Text);
            manipulaProduto manipulaProduto = new manipulaProduto();
            manipulaProduto.BuscarIDProduto();

            tbx_Nome.Text = Produto.NomeProduto1;
            tbx_Valor.Text = Produto.ValorProduto1.ToString();
            tbx_Marca.Text = Produto.MarcaProduto1;

            tbx_MatriculaProduto.Text = Produto.Id_Produto.ToString();
        }
    }
}
