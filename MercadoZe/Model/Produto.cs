﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Produto
    {
        private static int id_Produto;
        private static string NomeProduto;
        private static decimal ValorProduto;
        private static string MarcaProduto;

        public static int Id_Produto { get => id_Produto; set => id_Produto = value; }
        public static string NomeProduto1 { get => NomeProduto; set => NomeProduto = value; }
        public static decimal ValorProduto1 { get => ValorProduto; set => ValorProduto = value; }
        public static string MarcaProduto1 { get => MarcaProduto; set => MarcaProduto = value; }
    }
}
