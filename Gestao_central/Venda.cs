
namespace Gestao_central
{
    public class Venda
    {
        public string Vendedor { get; set; }
        public decimal Valor { get; set; }

        public Venda(string vendedor, decimal valor)
        {
            this.Vendedor = vendedor;
            this.Valor = valor;
        }

    }
    public class ComissaoService
    {
       public decimal CalcularComissao(decimal venda)
        {
            if (venda < 100)
            {
                return 0m;
            }
            else if (venda < 500)
            {
                return venda * 0.01m;
            }
            else
            {
               return venda * 0.05m;
            }
        }
    } 
}
    

   