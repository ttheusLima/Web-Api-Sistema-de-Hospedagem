using SistemaDeHospedagem.Models;

namespace Test
{
    public class DadosParaTestar
    {
        public Reserva GetTestReservas()
        {
            var testReservas = new Reserva { IdReserva = 1, Hospedes = GetTestCliente(), Suite = GetTestSuite(), DiasReservados = 3 };

            return testReservas;
        }

        public List<Cliente> GetTestCliente()
        {
            var testCliente = new List<Cliente>();
            testCliente.Add(new Cliente { IdCliente = 1, Nome = "Mariana Rodrigues", Cpf = 12345678, Telefone = 876543211 });

            return testCliente;
        }

        public Suite GetTestSuite()
        {
            Suite testSuite = new Suite();
            testSuite = new Suite(EnumTipoSuite.Suite_Comum, 2, 140);

            return testSuite;
        }
    }
}