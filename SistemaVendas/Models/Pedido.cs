namespace SistemaVendas.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; } = DateTime.Now;
        public decimal Total { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
    }

}
