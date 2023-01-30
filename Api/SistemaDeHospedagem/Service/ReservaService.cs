using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaDeHospedagem.Contexts;
using SistemaDeHospedagem.Interface;
using SistemaDeHospedagem.Models;

namespace SistemaDeHospedagem.Service
{
    public class ReservaService : IReservaService
    {
        public ReservaService(){ }
        
        private readonly HospedagemContext _context;
        
        public ReservaService(HospedagemContext context)
        {
            _context = context;
        }

        public void Post_Reserva(Reserva reserva)
        {
            _context.Reservas.Add(reserva);
            _context.SaveChanges();
        }

        public Reserva Get_ReservaPorId(int id)
        {
            return _context.Reservas.Include(x => x.Hospedes)
                                            .Include(x => x.Suite)
                                            .FirstOrDefault(r => r.IdReserva == id);
        }

        public List<Reserva> Get_Reservas()
        {
            return _context.Reservas.Include(x => x.Hospedes)
                                    .Include(x => x.Suite)
                                    .ToList();
        }

        public void Delete_Reserca(Reserva reserva)
        {
            _context.Reservas.Remove(reserva);
            _context.SaveChanges();
        }
    }
}