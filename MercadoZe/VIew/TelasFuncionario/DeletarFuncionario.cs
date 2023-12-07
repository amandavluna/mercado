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
    public partial class DeletarFuncionario : Form
    {
        public DeletarFuncionario()
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

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            Funcionario.Id_Funcionario = Convert.ToInt32(tbx_Matricula.Text);
            manipulaFuncionario manipulaFuncionario = new manipulaFuncionario();
            manipulaFuncionario.DeletarFuncionario();

            tbx_Matricula.Text = "";
            mtbx_Fone.Text = "0";
            tbx_Email.Text= "";
            tbx_Nome.Text= "";
        }
    }
}
