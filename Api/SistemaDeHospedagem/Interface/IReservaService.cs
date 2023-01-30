using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaDeHospedagem.Models;

namespace SistemaDeHospedagem.Interface
{
    public interface IReservaService
    {
        public void Post_Reserva(Reserva reserva);
        public Reserva Get_ReservaPorId(int id);
        public List<Reserva> Get_Reservas();
        public void Delete_Reserca(Reserva reserva);
    }
}