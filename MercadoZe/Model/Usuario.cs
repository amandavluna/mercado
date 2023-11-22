using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Usuario
    {
        private int id_Usuario;
        private static string TipoUsuario;
        private static string DataUsuario;
        private int id_ClienteFK;
        private int id_FuncionarioFK;

        public int Id_Usuario { get => id_Usuario; set => id_Usuario = value; }
        public static string TipoUsuario1 { get => TipoUsuario; set => TipoUsuario = value; }
        public static string DataUsuario1 { get => DataUsuario; set => DataUsuario = value; }
        public int Id_ClienteFK { get => id_ClienteFK; set => id_ClienteFK = value; }
        public int Id_FuncionarioFK { get => id_FuncionarioFK; set => id_FuncionarioFK = value; }
    }
}
