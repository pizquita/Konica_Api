using KonicaApi.Models;
using KonicaApi.Repositories;
using KonicaApi.ServicesClients;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace KonicaApi.Services
{
    public interface IUbicacionesServices
    {
        Task<bool> ActualizarPosicionPedido(int idPedido);
        UbicacionDto ObtenerUbicacion(int idPedido);
        int InsetarPosicionPedido(UbicacionDto ubicacion);

    }
    public class UbicacionesServices : IUbicacionesServices
    {
        private readonly IFCMServiceClients _IFCMServiceClients;
        private readonly IUbicacionRepository _ubicacionRepository;
        private readonly IPedidosRepository _iposRepository;

        public UbicacionesServices(IFCMServiceClients fCMServiceClients, IUbicacionRepository ubicacionRepository, IPedidosRepository iposRepository)
        {
            _IFCMServiceClients = fCMServiceClients;
            _ubicacionRepository = ubicacionRepository;
            _iposRepository = iposRepository;
        }

        ///Servicio que se encarga de solicitar la actualización de la posición a la aplicación
        public async Task<bool> ActualizarPosicionPedido(int idPedido)
        {                  
            var token = _iposRepository.ObtenerToken(idPedido);
            return await _IFCMServiceClients.SolicitarPosicion(token);
        }

        public UbicacionDto ObtenerUbicacion(int idPedido)
        {
            return _ubicacionRepository.ObtenerPosicionPedido(idPedido);
        }

        public int InsetarPosicionPedido(UbicacionDto ubicacion)
        {
            _ubicacionRepository.InsertarPosicionPedido(ubicacion);
            return 0;
        }
    }

}
