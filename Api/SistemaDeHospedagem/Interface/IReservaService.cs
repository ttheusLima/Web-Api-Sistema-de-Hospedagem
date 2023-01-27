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
        public Reserva GetReservaPorId(int id);
        public List<Reserva> Get_Produtos();
    }
}