using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class cliente
    {
        private static int id_Cliente;
        private static string NomeCliente;
        private static string EmailCliente;
        private static string CelularCliente;

        public static int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
        public static string NomeCliente1 { get => NomeCliente; set => NomeCliente = value; }
        public static string EmailCliente1 { get => EmailCliente; set => EmailCliente = value; }
        public static string CelularCliente1 { get => CelularCliente; set => CelularCliente = value; }
    }
}
