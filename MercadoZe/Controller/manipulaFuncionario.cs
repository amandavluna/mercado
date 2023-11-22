using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class manipulaFuncionario
    {
        public void AdicionarFuncionario() {

            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirFuncionario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@NomeFuncionario", Funcionario.NomeFuncionario1);
                cmd.Parameters.AddWithValue("@EmailFuncionario", Funcionario.EmailFuncionario1);
                cmd.Parameters.AddWithValue("@FoneFuncionario", Funcionario.FoneFuncionario1);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário Cadastrado com Sucesso.");
            }
            catch (Exception) {
                throw;
            }
        }

    }
}
