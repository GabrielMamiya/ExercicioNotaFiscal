using System;
using System.Collections.Generic;
using ExercicioNotaFiscalHard.dominio;

namespace ExercicioNotaFiscalHard
{
    class MainClass
    {

        public static List<Produto> listaDeProdutos = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>(); 

        public static void Main(string[] args)
        {

            listaDeProdutos.Add(new Produto(1001, "Cadeira Simples", 500.00));
            listaDeProdutos.Add(new Produto(1002, "Cadeira Alcochoada", 900.00));
            listaDeProdutos.Add(new Produto(1003, "Sofa de Tres Lugares", 2000.00));
            listaDeProdutos.Add(new Produto(1004, "Mesa Retangular", 1500.00));
            listaDeProdutos.Add(new Produto(1005, "Mesa Retangular", 2000.00));
            listaDeProdutos.Sort();

            int opcao = 0;

            while (opcao != 5){
                Tela.exibeMenu();


                try{
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e){
                    Console.WriteLine("Erro inesperado: " + e.Message);
                }

                if(opcao == 1 ){
                    Tela.listaProdutos();
                    opcao = 0;
                } else if (opcao == 2){
                    try{
                        Tela.cadastrarProduto();
                    }
                    catch (Exception e){
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                } else if (opcao == 3){
                    try{
                        Tela.cadastrarPedido();
                    }
                    catch(ModelException e){
                        Console.WriteLine("Erro de negocio: " + e.Message);
                    }
                    catch (Exception e){
                        Console.WriteLine("Erro Inesperado " + e.Message);
                    }
                } else if (opcao == 4){
                    try{
                        Tela.mostrarPedido();
                    }
                    catch (Exception e){
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                } else if (opcao == 5){
                    Console.WriteLine("Finalizando programa...");
                } else {
                    Console.WriteLine("Opcao invalida!");
                }


            }



        }
    }
}
