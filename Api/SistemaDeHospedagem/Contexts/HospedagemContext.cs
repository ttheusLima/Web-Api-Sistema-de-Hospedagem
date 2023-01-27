using Microsoft.EntityFrameworkCore;
using SistemaDeHospedagem.Models;

namespace SistemaDeHospedagem.Contexts
{
    public class HospedagemContext : DbContext
    {
        public HospedagemContext() { }

        public HospedagemContext(DbContextOptions<HospedagemContext> options) : base(options){ }
        
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<Suite> Suites { get; set; }

    }
}