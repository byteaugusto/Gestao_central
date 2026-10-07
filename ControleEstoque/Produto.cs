namespace ControleEstoque
{
    public class Produto
    {
        public int CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int Estoque { get; set; }
    }
    public class Movimentacao
    {
        public int IdMovimentacao { get; set; }
        public string DescricaoMovimentacao { get; set; }
        public int CodigoProduto { get; set; }
        public int Quantidade { get; set; }
    }
}
