using System;

namespace ExercicioNotaFiscalHard.dominio
{
    public class ItemPedido
    {
        public int quantidade { get; set; }
        public double porcentagemDesconto { get; set; }
        public Produto produto { get; set; }
        public Pedido pedido { get; set; }

        public ItemPedido(int quantidade, double porcentagemDesconto, Produto produto, Pedido pedido)
        {
            this.quantidade = quantidade;
            this.porcentagemDesconto = porcentagemDesconto;
            this.pedido = pedido;
            this.produto = produto;
        }

        public double subTotal(){
            double desconto = produto.precoDoProduto * (porcentagemDesconto / 100);
            return (produto.precoDoProduto - desconto) * quantidade;
        }

        public override string ToString()
        {
            return "Itens: \n" +
                produto.nomeDoProduto + ", Preco: " + produto.precoDoProduto + ", Qte: " + quantidade + "Desconto: " + porcentagemDesconto + "%, Subtotal: " + subTotal();
        }
    }
}
