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
    public partial class DeletarProduto : Form
    {
        public DeletarProduto()
        {
            InitializeComponent();
        }

        private void tbx_NumeroUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Produto.Id_Produto = Convert.ToInt32(tbx_Matricula.Text);
            manipulaProduto manipulaProduto = new manipulaProduto();
            manipulaProduto.BuscarIDProduto();

            tbx_Marca.Text = Produto.MarcaProduto1;
            tbx_Nome.Text = Produto.NomeProduto1;
            tbx_Valor.Text = Produto.ValorProduto1.ToString();

            tbx_Matricula.Text = Produto.Id_Produto.ToString();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Produto.Id_Produto = Convert.ToInt32(tbx_Matricula.Text);
            manipulaProduto manipulaProduto = new manipulaProduto();
            manipulaProduto.DeletarProduto();
            tbx_Marca.Text = "";
            tbx_Matricula.Text = "";
            tbx_Nome.Text = "";
            tbx_Valor.Text = "0";
        }
    }
}
