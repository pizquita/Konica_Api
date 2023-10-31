using KonicaApi.Models;
using KonicaApi.Repositories;
using KonicaApi.Services;
using KonicaApi.ServicesClients;
using Microsoft.AspNetCore.Mvc;

namespace KonicaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UbicacionesController : Controller
    {
        private IUbicacionesServices _ubicacionesServices;
        

        public UbicacionesController(IUbicacionesServices ubicacionesServices)
        {
            _ubicacionesServices = ubicacionesServices;            
        }

        ///Endpoint al que se llama con un idPedido para que la aplicación envíe su informción a la api
        [HttpGet(Name = "actualizar-posicion")]
        public async Task<IActionResult> SolicitarPosicion(int idPedido)
        {
            if (await _ubicacionesServices.ActualizarPosicionPedido(idPedido))
                return Ok();
            else return BadRequest();       
        }

        ///Endpoint que obtiene la última posición de la bbdd de un pedido
        [HttpGet(Name = "obtener-posicion-pedido")]        
        public IActionResult ObtenerUltimaPosicion(int idPedido)
        {
            return (IActionResult)_ubicacionesServices.ObtenerUbicacion(idPedido);
        }

        
        /// Este es el endpoint al que llama la app cada vez que se le solicita la posición y lo inserta en BBDD       
        [HttpPost (Name = "recibir-posicion")]
        public async Task<IActionResult> RecibirPosicion([FromBody] UbicacionDto ubicacionDto)
        {
            //Una vez se recibe la posicion de un pedido se guarda en BBDD
            //siempre se realiza un insert para poder mantener un historico de todas las posiciones de un pedido            
            
            _ubicacionesServices.InsetarPosicionPedido(ubicacionDto);

            return Ok();
        }

    }
}
