using Dapper.Extensions;
using KonicaApi.Controllers;
using KonicaApi.Models;

namespace KonicaApi.Repositories
{
    public interface IPedidosRepository
    {     
        int InsertarPedido(PedidoDto pedidoDto);
        int EliminarPedido(int pedidoDto);
        PedidoDto ObtenerPedido(int idPedido);
        string ObtenerToken(int idPedido);
    }

    //Para simplificar la conexión se realiza mediante Dapper
    public class PedidosRepository : IPedidosRepository
    {
        private readonly IDapper _repo;

       
        public PedidosRepository(IDapper repo)
        { 
            _repo = repo;
        }

        public int InsertarPedido(PedidoDto pedidoDto)
        {
            return 0;
        }

        public int EliminarPedido(int pedidoDto)
        {
            return 0;
        }

        public PedidoDto ObtenerPedido(int idPedido)
        {
            return new PedidoDto();            
        }

        public string ObtenerToken(int idPedido)
        {
            return "token";
        }
    }


}
