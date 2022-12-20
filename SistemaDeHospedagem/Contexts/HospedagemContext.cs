using Microsoft.EntityFrameworkCore;
using SistemaDeHospedagem.Models;

namespace SistemaDeHospedagem.Contexts
{
    public class HospedagemContext :  DbContext
    {
        public HospedagemContext(DbContextOptions<HospedagemContext> options) : base(options){ }

        public DbSet<Cliente> Clientes { get; set; } = null;
        public DbSet<Reserva> Reservas { get; set; } = null;
        public DbSet<Suite> Suites { get; set; } = null;
    }
}