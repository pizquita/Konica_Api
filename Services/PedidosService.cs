using KonicaApi.Models;
using KonicaApi.Repositories;

namespace KonicaApi.Services
{
    public interface IPedidosService
    {
        int InsertarPedido(PedidoDto pedidoDto);
        void EliminarPedido(int idPedido);
    }
    public class PedidosService : IPedidosService
    {
        private PedidosRepository PedidosRepository;

        public PedidosService(PedidosRepository pedidosRepository)
        {
            PedidosRepository = pedidosRepository;
        }

        public void EliminarPedido(int idPedido)
        {         
            PedidosRepository.EliminarPedido(idPedido);
        }

        public int InsertarPedido(PedidoDto pedidoDto)
        {         
            return PedidosRepository.InsertarPedido(pedidoDto);            
        }
    }
}
