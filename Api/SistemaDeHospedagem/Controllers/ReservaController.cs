using Microsoft.AspNetCore.Mvc;
using SistemaDeHospedagem.Models;
using SistemaDeHospedagem.Service;

namespace SistemaDeHospedagem.Controllers
{
    [ApiController]
    [Route("docs-api/[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly ReservaService _reservaService;

        public ReservaController(ReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpPost("Criar_Reserva")]
        public IActionResult PostReserva(Reserva reserva)
        {
            _reservaService.Post_Reserva(reserva);
            
            return CreatedAtAction("GetReservaPorId", new { id = reserva.IdReserva }, reserva);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reserva>> GetReservaPorId(int id)
        {
            var reserva = await Task.FromResult(_reservaService.Get_ReservaPorId(id));
            
            return reserva is null ? NotFound() : Ok(reserva);
        }

        [HttpGet("Obter_Todos")]
        public async Task<IEnumerable<Reserva>> GetTodasReservas()
        {
            return await Task.FromResult(_reservaService.Get_Reservas().ToList());
        }

        [HttpDelete("Deletar_Reserva")]
        public IActionResult DeleteReserva(int id)
        {
            var reserva = _reservaService.Get_ReservaPorId(id);

            if(reserva is null){ NotFound(); }

            _reservaService.Delete_Reserca(reserva);

            return NoContent(); 
        }
    }
}