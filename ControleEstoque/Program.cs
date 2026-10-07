using ControleEstoque;

List<Produto> produtos = new List<Produto>
{
    new Produto
    {
        CodigoProduto = 101,
        DescricaoProduto = "Caneta Azul",
        Estoque = 150
    },
    new Produto
    {
        CodigoProduto = 102,
        DescricaoProduto = "Caderno Universitário",
        Estoque = 75
    },
    new Produto
    {
        CodigoProduto = 103,
        DescricaoProduto = "Borracha Branca",
        Estoque = 200
    },
    new Produto
    {
        CodigoProduto = 104,
        DescricaoProduto = "Lápis Preto HB",
        Estoque = 320
    },
    new Produto
    {
        CodigoProduto = 105,
        DescricaoProduto = "Marcador de Texto Amarelo",
        Estoque = 90
    }
};

List<Movimentacao> movimentacoes = new List<Movimentacao>()
{
    new Movimentacao
    {
        IdMovimentacao = 1,
        DescricaoMovimentacao = "Entrada",
        CodigoProduto = 101,
        Quantidade = 20
    },
    new Movimentacao
    {
        IdMovimentacao = 2,
        DescricaoMovimentacao = "Saída",
        CodigoProduto = 101,
        Quantidade = 30
    },
    new Movimentacao
    {
        IdMovimentacao = 3,
        DescricaoMovimentacao = "Entrada",
        CodigoProduto = 103,
        Quantidade = 50
    },
    new Movimentacao
    {
        IdMovimentacao = 4,
        DescricaoMovimentacao = "Saída",
        CodigoProduto = 104,
        Quantidade = 40
    }
};

foreach (var movimentacao in movimentacoes)
{
    var encontrarProduto = produtos.FirstOrDefault(
        p => p.CodigoProduto == movimentacao.CodigoProduto);

    if (encontrarProduto == null)
    {
        Console.WriteLine("Código inválido");
    }
    else
    {
        Console.WriteLine($"ID da movimentação: {movimentacao.IdMovimentacao}");
        Console.WriteLine($"Código do produto: {encontrarProduto.CodigoProduto}");
        Console.WriteLine($"Produto: {encontrarProduto.DescricaoProduto}");
        Console.WriteLine($"Quantidade antes da operação: {encontrarProduto.Estoque}");

        if (movimentacao.DescricaoMovimentacao == "Entrada")
        {
            encontrarProduto.Estoque += movimentacao.Quantidade;

            Console.WriteLine(
                $"Estoque após a alteração: {encontrarProduto.Estoque}");
        }
        else if (movimentacao.DescricaoMovimentacao == "Saída")
        {
            encontrarProduto.Estoque -= movimentacao.Quantidade;

            Console.WriteLine(
                $"Estoque após a alteração: {encontrarProduto.Estoque}");
        }
        else
        {
            Console.WriteLine("Insira uma movimentação válida");
        }
    }
}