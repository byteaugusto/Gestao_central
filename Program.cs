using Gestao_central;
using System.Text.Json;
using System.IO;

string caminho = "vendas.json";

string json = File.ReadAllText(caminho);

JsonSerializerOptions opcoes = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

VendasArquivo? dados = JsonSerializer.Deserialize<VendasArquivo>(json, opcoes);


if (dados == null)
{
    Console.WriteLine("Lista nula");
}
else 
{

    List<Venda> vendas = dados.Vendas;
    Dictionary<string, decimal> comissoesPorVendedor = new Dictionary<string, decimal>();
    ComissaoService comissaoService = new ComissaoService();
    foreach (Venda dvenda in vendas)
    {
        if (comissoesPorVendedor.ContainsKey(dvenda.Vendedor))
        {
            decimal comissaoAtual = comissaoService.CalcularComissao(dvenda.Valor);

            decimal comissaoTotal = comissaoAtual + comissoesPorVendedor[dvenda.Vendedor];
            comissoesPorVendedor[dvenda.Vendedor] = comissaoTotal;
        }
        else
        {
            comissoesPorVendedor.Add(dvenda.Vendedor, comissaoService.CalcularComissao(dvenda.Valor));
        }
    }
    foreach (KeyValuePair<string, decimal> item in comissoesPorVendedor)
    {
        Console.WriteLine($"Vendedor: {item.Key} | Comissão total: {item.Value:F2}");
    }
}