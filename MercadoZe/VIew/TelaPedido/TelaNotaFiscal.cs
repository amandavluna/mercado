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
    public partial class TelaNotaFiscal : Form
    {
        public decimal totalFinal = 0;
        TelaPDV Tela;

        public void buscadDoDataGrid() {

            for (int i = 0; i < Tela.dataGridViewPDV.RowCount - 1; i++)

            {
                lbl_prodPedido.Text += "                       " + Tela.dataGridViewPDV.Rows[i].Cells[1].Value.ToString() + "\n";
                lbl_valorUnitPedido.Text += "                      " + Tela.dataGridViewPDV.Rows[i].Cells[2].Value.ToString() + "\n";
                lbl_qtdPedido.Text += "                        " + Tela.dataGridViewPDV.Rows[i].Cells[3].Value.ToString() + "\n";
                lbl_valorTotalPedido.Text += "                      " + "R$" + Tela.dataGridViewPDV.Rows[i].Cells[4].Value.ToString() + ",00" + "\n";
                totalFinal += Convert.ToInt32(Tela.dataGridViewPDV.Rows[i].Cells[4].Value);
            }

            lbl_TotalFinal.Text = "R$ " + totalFinal + ",00".ToString();

        }

        public TelaNotaFiscal(TelaPDV telaPDV)
        {
            InitializeComponent();
            Tela = telaPDV;

            buscadDoDataGrid();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void TelaNotaFiscal_Load(object sender, EventArgs e)
        {
            lbl_Data.Text = DateTime.Now.ToString();

        }

        private void btn_Finalizado_Click(object sender, EventArgs e)
        {
         
            for (int i = 0; i < Tela.dataGridViewPDV.RowCount - 1; i++)
            {
                Pedido.Id_ProdutoFK1 = Convert.ToInt32(Tela.dataGridViewPDV.Rows[i].Cells[0].Value.ToString());
                Pedido.QtdProduto = Convert.ToInt32(Tela.dataGridViewPDV.Rows[i].Cells[2].Value.ToString());
                Pedido.TotalItens1 = Convert.ToInt32(Tela.dataGridViewPDV.Rows[i].Cells[4].Value.ToString());
                Pedido.Id_FuncionarioFK1 = 1;
                Pedido.Id_ClienteFK1 = 1;
                Pedido.Id_ItensProdutosFK1 = 1;
                Pedido.TotalItens1 = totalFinal;
                Pedido.Id_CCP1 = 200;
            }

            manipulaPedido manipulaPedido = new manipulaPedido();
            manipulaPedido.CadastraPedido();




        }
    }
}
