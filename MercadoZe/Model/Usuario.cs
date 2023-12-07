using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Usuario
    {
        private static int id_Usuario;
        private static string TipoUsuario;
        private static string DataUsuario;
        private static string SenhaUsuario;
        private static int id_FuncionarioFK;

        public static int Id_Usuario { get => id_Usuario; set => id_Usuario = value; }
        public static string TipoUsuario1 { get => TipoUsuario; set => TipoUsuario = value; }
        public static string DataUsuario1 { get => DataUsuario; set => DataUsuario = value; }
        public static string SenhaUsuario1 { get => SenhaUsuario; set => SenhaUsuario = value; }
        public static int Id_FuncionarioFK { get => id_FuncionarioFK; set => id_FuncionarioFK = value; }
    }
    }

