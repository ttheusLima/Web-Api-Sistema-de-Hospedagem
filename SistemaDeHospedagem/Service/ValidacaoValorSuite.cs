using SistemaDeHospedagem.Models;

namespace SistemaDeHospedagem.Service
{
    public class ValidacaoValorSuite
    {
        public decimal ValidarValorDiariaPorSuite(Enum suite)
        {
            decimal valorPorSuite = default(decimal);

            switch(suite)
            {
                case EnumTipoSuite.Suite_Comum: valorPorSuite =  140.00M; break;
                case EnumTipoSuite.Demi_Suíte: valorPorSuite = 210.00M; break;
                case EnumTipoSuite.Suíte_Master: valorPorSuite = 380.00M; break;
            }

            return valorPorSuite;
        }
    }
}