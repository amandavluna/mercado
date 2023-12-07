using MercadoZe.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class manipulaUsuario
    {
        public void CadastrarUsuario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirUsuario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@TipoUsuario", Usuario.TipoUsuario1);
                cmd.Parameters.AddWithValue("@SenhaUsuario", Usuario.SenhaUsuario1);
                cmd.Parameters.AddWithValue("@Id_FuncionarioFK", Funcionario.Id_Funcionario);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário Cadastrado com Sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlterarUsuario()
        {

            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarUsuario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@id_FuncionarioFK", Usuario.Id_FuncionarioFK);
                cmd.Parameters.AddWithValue("@TipoUsuario", Usuario.TipoUsuario1);
                cmd.Parameters.AddWithValue("@SenhaUsuario", Usuario.SenhaUsuario1);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário alterado com Sucesso");
            }
            catch (Exception e) {


                MessageBox.Show(e.Message, "Usuário Alterado com Sucesso");
            }
            finally { cn.Close(); } 

            }

        public static BindingSource VisualizarTipoUsuario() {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarUsuarios", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TipoUsuario", Usuario.TipoUsuario1);
            cn.Open();
            cmd.ExecuteNonQuery();
 
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
         

        public void DeletarUsuario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarUsuario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try {
                cmd.Parameters.AddWithValue("@id_Usuario", Usuario.Id_Usuario);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluido com sucesso");

            }
            catch (Exception)
            {
                throw;
            }
  
            }


        public void VisualizarCodigoUsuario() 
            {

            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarUsuario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try {
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@Id_Funcionario", Usuario.Id_Usuario);
                cn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read()) {
                    Usuario.Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]);
                    Usuario.TipoUsuario1 = dr["TipoUsuario"].ToString();
                    Usuario.DataUsuario1 = dr["DataUsuario"].ToString();
                    Usuario.Id_FuncionarioFK = Convert.ToInt32(dr["Id_FuncionarioFK"]);
                    Usuario.SenhaUsuario1 = dr["SenhaUsuario"].ToString();
                    Funcionario.NomeFuncionario1 = dr["NomeFuncionario"].ToString();
                    Funcionario.EmailFuncionario1 = dr["EmailFuncionario"].ToString();
                }
                else
                {
                    Usuario.Id_Usuario = 0;
                    Usuario.TipoUsuario1 = "";
                    Usuario.DataUsuario1 = "";
                    Usuario.Id_FuncionarioFK = 0;
                    Usuario.SenhaUsuario1 = "";

                    MessageBox.Show("Busca Não Executada..");
                }



            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
                


