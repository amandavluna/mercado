using MercadoZe.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
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


            try {
                cmd.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente1);
                cmd.Parameters.AddWithValue("@EmailCliente", cliente.EmailCliente1);
                cmd.Parameters.AddWithValue("@CelularCliente", cliente.CelularCliente1);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com Sucesso.");
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
