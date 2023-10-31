using KonicaApi.Models;
using KonicaApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KonicaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : Controller
    {
        private readonly ILogger<PedidosController> _logger;
        private readonly IPedidosRepository _pedidosRepository;

        public PedidosController(ILogger<PedidosController> logger, IPedidosRepository pedidosRepository)
        {
            _logger = logger;
            _pedidosRepository = pedidosRepository;
        }


        [HttpPost(Name = "inserta-pedido")]
        public IActionResult InsertarPedido(PedidoDto pedidosDto)
        {
            if(_pedidosRepository.InsertarPedido(pedidosDto) > 0)
                return Ok(true); 
            else
                return BadRequest();             
        }

        
        [HttpPost(Name = "borrar-pedido")]
        public IActionResult EliminarPedido(int idPedido)
        {
            if(_pedidosRepository.EliminarPedido(idPedido) > 0)
                return Ok(true);
            else
                return BadRequest();

        }
    }
}
