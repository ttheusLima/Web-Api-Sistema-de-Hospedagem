using SistemaDeHospedagem.Controllers;
using SistemaDeHospedagem.Models;

namespace Test;
public class ReservaControllerTest
{  

    [SetUp]
    public void SetUp()
    {
    }

    [Test]
    public void RegistrarReserva_DeverarRegistrarUmaReserva()
    {
        //Arrange
        Reserva reserva = new DadosParaTestar().GetTestReservas();
        double expected = 1;
        var controller = new ReservaController().PostReserva(reserva);

        //Assert
        //Assert.IsNotNull(controller);
        Assert.AreEqual(expected, controller.Id);
    }

    
}