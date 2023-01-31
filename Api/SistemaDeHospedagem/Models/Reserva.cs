using System.ComponentModel.DataAnnotations;

namespace SistemaDeHospedagem.Models
{
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }
        public List<Cliente> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
    }
}