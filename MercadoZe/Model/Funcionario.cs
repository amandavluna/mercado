using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Funcionario
    {
        private static int id_Funcionario;
        private static string NomeFuncionario;
        private static string FoneFuncionario;
        private static string EmailFuncionario;

        public static int Id_Funcionario { get => id_Funcionario; set => id_Funcionario = value; }
        public static string NomeFuncionario1 { get => NomeFuncionario; set => NomeFuncionario = value; }
        public static string FoneFuncionario1 { get => FoneFuncionario; set => FoneFuncionario = value; }
        public static string EmailFuncionario1 { get => EmailFuncionario; set => EmailFuncionario = value; }
    }
}
