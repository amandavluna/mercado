using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class manipulaPedido
    {
        public void CadastraPedido() {

            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirItensProduto", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@Id_ProdutoFK", Pedido.Id_ProdutoFK1);
                cmd.Parameters.AddWithValue("@QtdProduto", Pedido.QtdProduto);
                cmd.Parameters.AddWithValue("@TotalProduto", Pedido.TotalItens1);


                if (Pedido.Id_CCP1 != 0){
                    CadastraPedidoFinal();
                }
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Itens Cadastrado com Sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

            public void CadastraPedidoFinal()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());

            SqlCommand cmd = new SqlCommand("P_InserirPedidos", cn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try

            {
                cmd.Parameters.AddWithValue("@Id_FuncionarioFK", Pedido.Id_FuncionarioFK1);

                cmd.Parameters.AddWithValue("@Id_ClienteFK", Pedido.Id_ClienteFK1);

                cmd.Parameters.AddWithValue("@Id_ItensProdutosFK", Pedido.Id_ItensProdutosFK1);

                cmd.Parameters.AddWithValue("@TotalPedido", Pedido.TotalPedido1);

                cmd.Parameters.AddWithValue("@Id_CCP", Pedido.Id_CCP1);


                cn.Open();

                cmd.ExecuteNonQuery();

            }

            catch (Exception)

            {
                throw;

            }

        }
    }
}
