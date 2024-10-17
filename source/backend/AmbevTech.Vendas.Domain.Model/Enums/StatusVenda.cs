using System.ComponentModel;

namespace PoCVendas.Vendas.Domain.Model.Enuns
{
    public enum StatusVenda
    {
        [Description("Venda Não Cancelada")]
        NaoCancelada = 0,
        [Description("Venda Cancelada")]
        Cancelada = 1        
    }
}
