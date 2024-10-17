namespace AmbevTech.Vendas.Comunication.Requests
{
    public class RequestRegisterVendaJson
    {
        public DateTime DataVenda { get; set; } = DateTime.Now;

        public long ClienteKey { get; set; }
        public string ClienteNome { get; set; } = string.Empty;

        public decimal ValorTotal { get; set; }

        public long FilialKey { get; set; }
        public string FilialNome { get; set; } = string.Empty;

        //public IList<Item> Itens { get; private set; }

        //public StatusVenda Status { get; private set; }
    }
}
