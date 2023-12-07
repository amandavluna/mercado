using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
                cmd.Parameters.AddWithValue("@FoneFuncionario", Funcionario.FoneFuncionario1);
                cmd.Parameters.AddWithValue("@EmailFuncionario", Funcionario.EmailFuncionario1);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário Cadastrado com Sucesso.");
            }
            catch (Exception) {
                throw;
            }
        }

        public void BuscarFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarFuncionario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@Id_Funcionario", Funcionario.Id_Funcionario);
                cn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Funcionario.Id_Funcionario = Convert.ToInt32(dr["Id_Funcionario"]);
                    Funcionario.NomeFuncionario1 = dr["NomeFuncionario"].ToString();
                    Funcionario.EmailFuncionario1 = dr["EmailFuncionario"].ToString();
                    Funcionario.FoneFuncionario1 = dr["FoneFuncionario"].ToString();
                }
                else
                {
                    Funcionario.Id_Funcionario = 0;
                    Funcionario.NomeFuncionario1 = "";
                    Funcionario.EmailFuncionario1 = "";
                    Funcionario.FoneFuncionario1 = "";

                    MessageBox.Show("Busca Não Executada..");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public void AlterarFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarFuncionario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id_Funcionario", Funcionario.Id_Funcionario);
                cmd.Parameters.AddWithValue("@NomeFuncionario", Funcionario.NomeFuncionario1);
                cmd.Parameters.AddWithValue("@EmailFuncionario", Funcionario.EmailFuncionario1);
                cmd.Parameters.AddWithValue("@FoneFuncionario", Funcionario.FoneFuncionario1);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário alterado com Sucesso");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Funcionário Alterado com Sucesso");
            }
            finally { cn.Close(); }
        }


        public void DeletarFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarFuncionario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id_Funcionario", Funcionario.Id_Funcionario);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário excluido com sucesso");

            }
            catch (Exception)
            {
                throw;

            }


        }



        public static BindingSource VisualizarNome()
        {

            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarFuncionarioNome", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NomeFuncionario", Funcionario.NomeFuncionario1);
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
