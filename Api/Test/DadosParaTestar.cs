using SistemaDeHospedagem.Models;

namespace Test
{
    public class DadosParaTestar
    {
        public List<Reserva> GetTestReservas()
        {
            var testReservas = new List<Reserva>();
            testReservas.Add(new Reserva { IdReserva = 1, Hospedes = GetTestCliente(), Suite = GetTestSuite()[0], DiasReservados = 3 }); 
            testReservas.Add(new Reserva { IdReserva = 2, Hospedes = GetTestCliente(), Suite = GetTestSuite()[1], DiasReservados = 10 }); 
            testReservas.Add(new Reserva { IdReserva = 3, Hospedes = GetTestCliente(), Suite = GetTestSuite()[2], DiasReservados = 5 }); 

            return testReservas;
        }

        public List<Cliente> GetTestCliente()
        {
            var testCliente = new List<Cliente>();
            testCliente.Add(new Cliente { IdCliente = 1, Nome = "Mariana Rodrigues", Cpf = 12345678, Telefone = 876543211 });
            testCliente.Add(new Cliente { IdCliente = 2, Nome = "Matheus Lima", Cpf = 87654321, Telefone = 123456788 });
            testCliente.Add(new Cliente { IdCliente = 3, Nome = "Talita Lopes", Cpf = 18273645, Telefone = 443215678 });

            return testCliente;
        }

        public List<Suite> GetTestSuite()
        {
            var testSuite = new List<Suite>();
            testSuite.Add(new Suite {idSuite = 1, TipoSuite = EnumTipoSuite.Suite_Comum, CapacidadeSuite = 2, ValorDiaria = 170M } );
            testSuite.Add(new Suite {idSuite = 2, TipoSuite = EnumTipoSuite.Suite_Comum, CapacidadeSuite = 2, ValorDiaria = 170M } );
            testSuite.Add(new Suite {idSuite = 3, TipoSuite = EnumTipoSuite.Suite_Comum, CapacidadeSuite = 2, ValorDiaria = 170M } );
        
            return testSuite;
        }

    }
}