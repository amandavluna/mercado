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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto.NomeProduto1 = tbx_NomeProduto.Text;
            Produto.ValorProduto1 = tbx_ValorProduto.Text;
            Produto.MarcaProduto1 = tbx_MarcaProduto.Text;

            manipulaProduto manipulaProduto = new manipulaProduto();
            manipulaProduto.AdicionarProduto();
        }
    }
}
