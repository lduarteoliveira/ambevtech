
using PoCVendas.Vendas.Domain.Model.Enuns;
using PoCVendas.Vendas.Domain.Model.ValueObjects;

namespace AmbevTech.Vendas.Domain.Model.Entities
{
    public class Venda : Entity
    {
        public DateTime DataVenda { get; private set; } = DateTime.Now;

        public long ClienteKey { get; private set; }
        public Cliente Cliente { get; private set; } = new Cliente();

        public ValorMoeda ValorTotal { get; private set; }

        public long FilialKey { get; private set; }
        public Filial Filial { get; set; } = new Filial();

        public IList<Item> Itens { get; private set; }

        public StatusVenda Status { get; private set; }

        public Venda()
        {
            Itens = [];
            ValorTotal = new ValorMoeda();
        }

        public void Criar(Cliente cliente, Filial filial, Item item, DateTime dataVenda)
        {
            ArgumentNullException.ThrowIfNull(cliente, nameof(cliente));
            ArgumentNullException.ThrowIfNull(filial, nameof(filial));
            ArgumentNullException.ThrowIfNull(item, nameof(item));

            ClienteKey = cliente.Id;
            Cliente = cliente;
            FilialKey = filial.Id;
            Filial = filial;
            DataVenda = dataVenda;
            Itens = [item];
            CalcularValorTotal(item);
            Status = StatusVenda.NaoCancelada;
        }

        private void CalcularValorTotal(Item item)
        {
            ValorTotal.Valor += item.ValorTotal.Valor;
        }

        public void AdicionarItem()
        {
        }

        public void RemoverItem()
        {
        }

        public void CancelarVenda()
        {
        }

        public void AlterarVenda()
        {
        }
    }
}
