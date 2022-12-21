using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaDeHospedagem.Contexts;
using SistemaDeHospedagem.Models;

namespace SistemaDeHospedagem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly HospedagemContext _context;

        public ReservaController(){ }

        public ReservaController(HospedagemContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Reserva>> PostReserva(Reserva reserva)
        {
            _context.Reservas.Add(reserva);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction("GetReservaPorId", new { id = reserva.IdReserva }, reserva);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reserva>> GetReservaPorId(int id)
        {
            var getReserva = await _context.Reservas.Include(x => x.Hospedes)
                                                    .Include(x => x.suite)
                                                    .SingleAsync(x => x.IdReserva == id);

            if(getReserva == null)
            {
                return NotFound();
            }
            
            return getReserva;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Reserva>> DeleteReservaPorId(int id)
        {
            var deleteReserva = await _context.Reservas.FindAsync(id);

            if(deleteReserva == null)
                return NotFound();
            
            _context.Reservas.Remove(deleteReserva);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}