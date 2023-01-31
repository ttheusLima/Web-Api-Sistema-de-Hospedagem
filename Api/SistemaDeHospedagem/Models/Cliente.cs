using System.ComponentModel.DataAnnotations;

namespace SistemaDeHospedagem.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Telefone { get; set; }
    }
}