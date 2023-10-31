using KonicaApi.ServicesClients.Models;

namespace KonicaApi.ServicesClients
{

    public interface IFCMServiceClients
    {
        Task<bool> SolicitarPosicion(string token);
    }

    public class FCMServiceClients : IFCMServiceClients
    {
        private readonly HttpClient _client;


        public FCMServiceClients(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("");//Cogerlo de settings
        }

        /// <summary>
        /// Este método llama a la api de FCM para enviar un mensaje a las aplicaciones solicitando la posición
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<bool> SolicitarPosicion(string token)
        {            
            return true;
        }
    }
}
