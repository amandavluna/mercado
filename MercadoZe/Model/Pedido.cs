using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Pedido
    {

        private static int Id_Pedido;
        private static int Id_FuncionarioFK;
        private static int Id_ClienteFK;
        private static int Id_ItensProdutosFK;
        private static DateTime DataCompra;
        private static int TotalPedido;
        private static int Id_ProdutoFK;
        private static int qtdProduto;
        private static decimal TotalItens;
        private static int Id_CCP;

        public static int Id_Pedido1 { get => Id_Pedido; set => Id_Pedido = value; }
        public static int Id_FuncionarioFK1 { get => Id_FuncionarioFK; set => Id_FuncionarioFK = value; }
        public static int Id_ClienteFK1 { get => Id_ClienteFK; set => Id_ClienteFK = value; }
        public static int Id_ItensProdutosFK1 { get => Id_ItensProdutosFK; set => Id_ItensProdutosFK = value; }
        public static DateTime DataCompra1 { get => DataCompra; set => DataCompra = value; }
        public static int TotalPedido1 { get => TotalPedido; set => TotalPedido = value; }
        public static int Id_ProdutoFK1 { get => Id_ProdutoFK; set => Id_ProdutoFK = value; }
        public static int QtdProduto { get => qtdProduto; set => qtdProduto = value; }
        public static decimal TotalItens1 { get => TotalItens; set => TotalItens = value; }
        public static int Id_CCP1 { get => Id_CCP; set => Id_CCP = value; }
    }
}
