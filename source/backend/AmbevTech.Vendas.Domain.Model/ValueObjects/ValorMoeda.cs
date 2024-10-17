
namespace PoCVendas.Vendas.Domain.Model.ValueObjects
{
    public class ValorMoeda
    {
        public decimal Valor { get; set; }

        public string Moeda { get; set; }

        public ValorMoeda()
        {
            Moeda = "R$";
        }
    }
}
