using MercadoZe.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class manipulaCliente
    {
        public void AdicionarCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirCliente", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente1);
                cmd.Parameters.AddWithValue("@EmailCliente", cliente.EmailCliente1);
                cmd.Parameters.AddWithValue("@CelularCliente", cliente.CelularCliente1);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com Sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BuscarCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarCliente", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@Id_Cliente", cliente.Id_Cliente);
                cn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    cliente.Id_Cliente = Convert.ToInt32(dr["Id_Cliente"]);
                    cliente.NomeCliente1 = dr["NomeCliente"].ToString();
                    cliente.EmailCliente1 = dr["EmailCliente"].ToString();
                    cliente.CelularCliente1 = dr["CelularCliente"].ToString();
                }
                else
                {
                    cliente.Id_Cliente = 0;
                    cliente.NomeCliente1 = "";
                    cliente.EmailCliente1 = "";
                    cliente.CelularCliente1 = "";

                    MessageBox.Show("Busca Não Executada..");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void AlterarCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarCliente", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id_Cliente", cliente.Id_Cliente);
                cmd.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente1);
                cmd.Parameters.AddWithValue("@EmailCliente", cliente.EmailCliente1);
                cmd.Parameters.AddWithValue("@CelularCliente", cliente.CelularCliente1);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado com Sucesso");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Cliente Alterado com Sucesso");
            }
            finally { cn.Close(); }
        }

        public void DeletarCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarCliente", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id_Cliente", cliente.Id_Cliente);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente excluido com sucesso");

            }
            catch (Exception)
            {
                throw;

            }




        }


        public static BindingSource VisualizarNome()
        {

            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarClienteNome", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente1);
            cn.Open();
            cmd.ExecuteNonQuery();


            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);


            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;
            return dados;

        }

    }
}