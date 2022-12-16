using System.ComponentModel.DataAnnotations;

namespace SistemaDeHospedagem.Models
{
    public class Reserva
    {
        public Reserva(){ }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        [Key]
        public int IdReserva { get; set; }
        public List<Cliente> Hospedes { get; set; }
        public Suite suite { get; set; }
        public int DiasReservados { get; set; }
    }
}