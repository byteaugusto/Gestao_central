using CalculoJuros;

Juros juros = new Juros
{
    Valor = 1000,
    DataVencimento = new DateTime(2026, 10, 5)
};

var diaDeHoje = DateTime.Today - juros.DataVencimento;

if (DateTime.Today > juros.DataVencimento)
{
    var juro = juros.Valor * 0.025 * diaDeHoje.Days;
    Console.WriteLine($"Juros totais: {juro}");
}
else
{
    Console.WriteLine("Não há juros a pagar.");
}