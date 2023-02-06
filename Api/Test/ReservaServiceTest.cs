using Microsoft.EntityFrameworkCore;
using Moq;
using SistemaDeHospedagem.Contexts;
using SistemaDeHospedagem.Interface;
using SistemaDeHospedagem.Models;
using SistemaDeHospedagem.Service;

namespace Test
{
    public class ReservaServiceTest
    {
        private Mock<DbSet<Reserva>> _dbSet;
        private Mock<HospedagemContext> _context;
        private IReservaService _repository;

        [SetUp]
        public void Setup()
        {
            var sampleData = new List<Reserva>(new DadosParaTestar().GetTestReservas()).AsQueryable();

            _dbSet = new Mock<DbSet<Reserva>>();
            _dbSet.As<IQueryable<Reserva>>().Setup(x => x.Provider).Returns(sampleData.Provider);
            _dbSet.As<IQueryable<Reserva>>().Setup(x => x.Expression).Returns(sampleData.Expression);
            _dbSet.As<IQueryable<Reserva>>().Setup(x => x.ElementType).Returns(sampleData.ElementType);
            _dbSet.As<IQueryable<Reserva>>().Setup(x => x.GetEnumerator()).Returns(sampleData.GetEnumerator());
 
            _context = new Mock<HospedagemContext>();
            _context.Setup(x => x.Reservas).Returns(_dbSet.Object);
 
            _repository = new ReservaService(_context.Object);
        }

        [Test]
        public void PostReserva_DeverarCriarUmaNovaReserva()
        {

            var simplesSuite = new Suite {IdSuite = 4, TipoSuite = EnumTipoSuite.Suite_Comum, CapacidadeSuite = 2, ValorDiaria = 170M };
            var simplesCliente = new List<Cliente>();
            simplesCliente.Add(new Cliente { IdCliente = 4, Nome = "Amanda Silva", Cpf = 16645678, Telefone = 873333211 });
            var simplesDadosReserva = new Reserva { IdReserva = 4, Suite = simplesSuite, Hospedes = simplesCliente, DiasReservados = 3 };

            _repository.Post_Reserva(simplesDadosReserva);
           
            _dbSet.Verify(m => m.Add(It.IsAny<Reserva>()), Times.Once);
            _context.Verify(m => m.SaveChanges(), Times.Once);
        }

        [Test]
        public void GetReservaPorId_DeverarRetornarReservaPorId()
        {
            var listaReserva = new DadosParaTestar().GetTestReservas();
            var reserva = _repository.Get_ReservaPorId(2);

            Assert.IsNotNull(reserva);
            Assert.AreEqual(listaReserva[1].IdReserva, reserva.IdReserva);
        }

        [Test]
        public void GetTodasReservas_DeverarRetornarTodasReservas()
        {
            var reservas = _repository.Get_Reservas() as List<Reserva>;

            Assert.IsNotNull(reservas);
            Assert.AreEqual(3, reservas.Count());
        }

        [Test]
        public void DeleteReserva_DeverarDeletarUmaReserva()
        {
            var reservaBanco = _repository.Get_ReservaPorId(2);
            _repository.Delete_Reserva(reservaBanco);

            _dbSet.Verify(m => m.Remove(It.IsNotIn<Reserva>()), Times.Once);
            _context.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}