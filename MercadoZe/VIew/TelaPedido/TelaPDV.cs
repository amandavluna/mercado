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

namespace MercadoZe.VIew.TelaPedido
{
    public partial class TelaPDV : Form
    {
        public decimal totalFinal = 0;

        public TelaPDV()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_Qtde_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            dataGridViewPDV.Rows.Add(
            tbx_CodigoBarra.Text,
            lbl_Produto.Text,
            lbl_Qtde.Text,
            lbl_ValorUnitario.Text,
            lbl_Total.Text);

            int qtd = Convert.ToInt32(lbl_Qtde.Text);
            decimal vUnitario = Convert.ToDecimal(lbl_ValorUnitario.Text);
            decimal total = qtd + vUnitario;
            totalFinal += total;
            lbl_Venda.Text = "R$    " + totalFinal.ToString();

        }

        private void TelaPDV_Load(object sender, EventArgs e)
        {

        }

        private void TelaPDV_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            lbl_CodigoBarra.Text = tbx_CodigoBarra.Text;
            lbl_Qtde.Text = tbx_Qtde.Text;
            Produto.Id_Produto = Convert.ToInt32(tbx_CodigoBarra.Text);
            manipulaProduto produto = new manipulaProduto();
            produto.BuscarProduto();


            lbl_Produto.Text = Produto.NomeProduto1;
            lbl_ValorUnitario.Text = Produto.ValorProduto1.ToString();
            decimal vProduto = Produto.ValorProduto1;
            int qtdProduto = Convert.ToInt32(tbx_Qtde.Text);

            Produto.ValorProduto1 = Convert.ToDecimal(lbl_ValorUnitario.Text);

            lbl_Total.Text = (vProduto * qtdProduto).ToString();

        }

        private void btrn_FecharVenda_Click(object sender, EventArgs e)
        {
            TelaNotaFiscal notaFiscal = new TelaNotaFiscal(this);
            notaFiscal.Show();
        }
    }
}
