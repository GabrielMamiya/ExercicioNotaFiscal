using System;
using System.Globalization;
using ExercicioNotaFiscalHard.dominio;


namespace ExercicioNotaFiscalHard
{
    public class Tela
    {

        // Interacoes com o usuario.

        public static void exibeMenu(){
            Console.WriteLine("1 - Listar Produtos Ordenadamente");
            Console.WriteLine("2 - Cadastrar Produto");
            Console.WriteLine("3 - Cadastrar Pedido");
            Console.WriteLine("4 - Mostrar Dados de um Pedido");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();
            Console.WriteLine("Digite uma opcao: ");
        }

        public static void listaProdutos(){

            Console.WriteLine("LISTA DE PRODUTOS: ");
            for (var i = 0; i < MainClass.listaDeProdutos.Count; i++){
                Console.WriteLine(MainClass.listaDeProdutos[i]);
            }

        }

        public static void cadastrarProduto(){
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descricao: ");
            string descricao = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());
            Produto P = new Produto(codigo, descricao, preco);
            MainClass.listaDeProdutos.Add(P);
            MainClass.listaDeProdutos.Sort();
        }

        public static void cadastrarPedido(){
            Console.WriteLine("Digite os dados do pedido: ");
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Quantos itens tem o pedido? ");
            int quantidade = int.Parse(Console.ReadLine());
            Pedido p = new Pedido(codigo, dia, mes, ano);
            for (int i = 0; i < quantidade; i++){
                Console.WriteLine("Digite os dados do " + (i + 1) + " pedido: ");
                Console.Write("Produto (Codigo): ");
                int codigoDoProduto = int.Parse(Console.ReadLine());
                int pos = MainClass.listaDeProdutos.FindIndex(x => x.codigoDoProduto == codigoDoProduto);
                if( pos == -1){
                    throw new ModelException("Codigo de produto nao encontrado: " + codigoDoProduto);
                } 
                Console.Write("Quantidade: ");
                int quantidadeDoProduto = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem do desconto: ");
                double porcentagemDeDescontoDoProduto = double.Parse(Console.ReadLine());

                ItemPedido itemPedido = new ItemPedido(quantidadeDoProduto, porcentagemDeDescontoDoProduto, MainClass.listaDeProdutos[pos] , p );
                p.itens.Add(itemPedido);
            }

            MainClass.pedidos.Add(p);
            //int posicao = MainClass.pedidos.FindIndex(x => x.codigo == codigo);
            //Console.WriteLine(MainClass.pedidos[posicao]);
        }

        public static void mostrarPedido(){
            Console.Write("Digite o codigo do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = MainClass.pedidos.FindIndex(x => x.codigo == codPedido);
            if(pos == -1){
                throw new ModelException("Codigo do pedido nao encontrado: " + codPedido);
            }
            Console.WriteLine(MainClass.pedidos[pos]);

        }

    }
}

//menu + digita opcao

//lista produtos