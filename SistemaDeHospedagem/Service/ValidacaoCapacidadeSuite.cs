using SistemaDeHospedagem.Models;

namespace SistemaDeHospedagem.Service
{
    public class ValidacaoCapacidadeSuite
    {
        public int CapacidadePorSuite(Enum suite)
        {
            int capacidadePorSuite = default(int);

            switch(suite)
            {
                case EnumTipoSuite.Suite_Comum: capacidadePorSuite =  2; break;
                case EnumTipoSuite.Demi_Suíte: capacidadePorSuite = 3; break;
                case EnumTipoSuite.Suíte_Master: capacidadePorSuite = 9; break;
            }

            return capacidadePorSuite;
        }
    }
}