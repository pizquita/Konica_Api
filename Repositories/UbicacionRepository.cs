using Dapper.Extensions;
using KonicaApi.Models;

namespace KonicaApi.Repositories
{
    public interface IUbicacionRepository 
    {
        UbicacionDto ObtenerPosicionPedido(int idPedido);
        int InsertarPosicionPedido(UbicacionDto ubicacionDto);
    }
    public class UbicacionRepository : IUbicacionRepository
    {
        private readonly IDapper _repo;       

        public UbicacionRepository(IDapper repo)
        {
            _repo = repo;
        }

        //Obtiene la última posición de un pedido en bbdd
        public UbicacionDto ObtenerPosicionPedido(int idPedido)
        {
            return new UbicacionDto();
        }

        ///inserta en la tabla de PosicionPedido para mantener el histórico de posiciones
        public int InsertarPosicionPedido(UbicacionDto ubicacionDto)
        {
            return 0;
        }
    }
}
