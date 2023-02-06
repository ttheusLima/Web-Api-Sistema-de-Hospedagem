using System.ComponentModel.DataAnnotations;

namespace SistemaDeHospedagem.Models
{
    public class Suite
    {
        
        [Key]
        public int IdSuite { get; set; }
        public EnumTipoSuite TipoSuite { get; set; }
        public int CapacidadeSuite { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}