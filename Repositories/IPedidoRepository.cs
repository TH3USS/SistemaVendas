using SistemaVendas.Models;

namespace SistemaVendas.Repositories
{
    public interface IPedidoRepository
    {
        IEnumerable<Pedido> GetAll();
        Pedido GetById(int id);
        void Add(Pedido pedido);
    }

}
