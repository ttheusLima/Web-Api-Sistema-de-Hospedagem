using System.ComponentModel.DataAnnotations;

namespace SistemaDeHospedagem.Models
{
    public class Cliente
    {
        public Cliente(){ }

        public Cliente(string nome, int cpf, int telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }

        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Telefone { get; set; }
    }
}