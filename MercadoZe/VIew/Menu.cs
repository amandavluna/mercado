using MercadoZe.VIew.TelaPedido;
using MercadoZe.VIew.TelasCliente;
using MercadoZe.VIew.TelasFuncionario;
using MercadoZe.VIew.TelasProduto;
using MercadoZe.VIew.TelasUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoZe.VIew
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.Show();
        }

        private void cadastrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.Show();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarUsuario alterarUsuario = new AlterarUsuario();
            alterarUsuario.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarUsuario pesquisarUsuario = new PesquisarUsuario();
            pesquisarUsuario.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletarUsuario deletarUsuario = new DeletarUsuario();
            deletarUsuario.Show();
        }

        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPDV telaPDV = new TelaPDV();
            telaPDV.Show();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlterarProduto alterarProduto = new AlterarProduto();
            alterarProduto.Show();
        }

        private void deletarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeletarProduto deletarProduto = new DeletarProduto();
            deletarProduto.Show();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisarProduto pesquisarProduto = new PesquisarProduto();
            pesquisarProduto.Show();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AlterarFuncionario alterarFuncionario = new AlterarFuncionario();
            alterarFuncionario.Show();
        }

        private void deletarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeletarFuncionario deletar = new DeletarFuncionario();
            deletar.Show();
        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PesquisarFuncionario pesquisarFuncionario = new PesquisarFuncionario();
            pesquisarFuncionario.Show();
        }

        private void alterarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AlterarCliente alterarCliente = new AlterarCliente();
            alterarCliente.Show();
        }

        private void deletarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeletarCliente deletarCliente = new DeletarCliente();
            deletarCliente.Show();
        }

        private void pesquisarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PesquisarCliente pesquisarCliente = new PesquisarCliente();
            pesquisarCliente.Show();
        }
    }
}
