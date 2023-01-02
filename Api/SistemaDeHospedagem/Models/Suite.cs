using System.ComponentModel.DataAnnotations;

namespace SistemaDeHospedagem.Models
{
    public class Suite
    {
        public Suite(){ }

        public Suite(EnumTipoSuite tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        [Key]
        public int idSuite { get; set; }
        public EnumTipoSuite TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}