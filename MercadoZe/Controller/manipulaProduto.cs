using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class manipulaProduto
    {
        public void AdicionarProduto()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirProduto", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@NomeProduto", Produto.NomeProduto1);
                cmd.Parameters.AddWithValue("@ValorProduto", Produto.ValorProduto1);
                cmd.Parameters.AddWithValue("@MarcaProduto", Produto.MarcaProduto1);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto Cadastrado com Sucesso.");
            }
            catch (Exception) {
                throw;
            }

        }
    }
}
