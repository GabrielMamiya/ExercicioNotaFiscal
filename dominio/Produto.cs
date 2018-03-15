using System;


namespace ExercicioNotaFiscalHard.dominio
{
    public class Produto : IComparable
    {
        public int codigoDoProduto { get; set; }
        public string nomeDoProduto { get; set; }
        public double precoDoProduto { get; set; }

        public Produto(int codigoDoProduto, string nomeDoProduto, double precoDoProduto)
        {
            this.codigoDoProduto = codigoDoProduto;
            this.nomeDoProduto = nomeDoProduto;
            this.precoDoProduto = precoDoProduto;
        }

        public override string ToString()
        {
            return codigoDoProduto + ", " + nomeDoProduto + ", " + precoDoProduto;
            //string.Format("[Produto: codigoDoProduto={0}, nomeDoProduto={1}, precoDoProduto={2}]", codigoDoProduto, nomeDoProduto, precoDoProduto);

        }

        public int CompareTo(object obj){
            Produto outro = (Produto)obj;
            int resultado = nomeDoProduto.CompareTo(outro.nomeDoProduto);
            if(resultado != 0){
                return resultado;
            } else {
                return -precoDoProduto.CompareTo(outro.precoDoProduto);
            }
        }
    }
}
