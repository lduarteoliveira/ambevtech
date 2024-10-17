
using PoCVendas.Vendas.Domain.Model.ValueObjects;


namespace AmbevTech.Vendas.Domain.Model.Entities
{
    public class Item : Entity
    {
        public readonly long ProdutoKey;

        public readonly Produto Produto;

        public readonly int Quantidade;

        public ValorMoeda ValorUnitario { get; set; } = new ValorMoeda();

        public ValorMoeda ValorDesconto { get; set; } = new ValorMoeda();

        public ValorMoeda ValorTotal
        {
            get
            {
                return new ValorMoeda() { Valor = Quantidade * ValorUnitario.Valor };
            }
        }

        public Item(Produto produto, int quantidade)
        {
            ArgumentNullException.ThrowIfNull(produto, nameof(produto));

            if (quantidade <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantidade), "A quantidade deve ser maior que zero.");
            }

            Produto = produto;
            ProdutoKey = produto.Id;
            Quantidade = quantidade;
        }
    }
}
