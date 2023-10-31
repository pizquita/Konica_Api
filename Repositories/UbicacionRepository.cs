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

        public UbicacionDto ObtenerPosicionPedido(int idPedido)
        {
            return new UbicacionDto();
        }

        public int InsertarPosicionPedido(UbicacionDto ubicacionDto)
        {
            //inserta en la tabla de PosicionPedido
            return 0;
        }
    }
}
