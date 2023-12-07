using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class manipulaProduto
    {

        public static BindingSource VisualizarID1()
        {

            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarProdutoNome", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NomeProduto", Produto.NomeProduto1);
            cn.Open();
            cmd.ExecuteNonQuery();


            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);


            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;
            return dados;

        }

        public void CadastroProduto()
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

        public void DeletarProduto()
        {
                SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
                SqlCommand cmd = new SqlCommand("P_DeletarProduto", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    cmd.Parameters.AddWithValue("@Id_Produto", Produto.Id_Produto);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto excluido com sucesso");

                }
                catch (Exception)
                {
                throw;

            }



        }

        public void AlterarProduto()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarProdutos", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id_Produto", Produto.Id_Produto);
                cmd.Parameters.AddWithValue("@NomeProduto", Produto.NomeProduto1);
                cmd.Parameters.AddWithValue("@ValorProduto", Produto.ValorProduto1);
                cmd.Parameters.AddWithValue("@MarcaProduto", Produto.MarcaProduto1);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto alterado com Sucesso");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Produto Alterado com Sucesso");
            }
            finally { cn.Close(); }
        }

        public void BuscarProduto()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarProduto", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@Id_Produto", Produto.Id_Produto);
                cn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Produto.Id_Produto = Convert.ToInt32(dr["Id_Produto"]);
                    Produto.NomeProduto1 = dr["NomeProduto"].ToString();
                    Produto.MarcaProduto1 = dr["MarcaProduto"].ToString();
                    Produto.ValorProduto1 = Convert.ToInt32(dr["ValorProduto"]);
                }
                else
                {
                    Produto.Id_Produto = 0;
                    Produto.NomeProduto1 = "";
                    Produto.MarcaProduto1 = "";
                    Produto.ValorProduto1 = 0;

                    MessageBox.Show("Busca Não Executada..");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



    }
}

