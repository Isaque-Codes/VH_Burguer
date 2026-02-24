using VH_Burguer.Exceptions;

namespace VH_Burguer.Applications.Regras
{
    public class ValidarDataExpiracaoPromocao
    {
        public static void ValidarDataExpiracao(DateTime DataExpiracao)
        {
            if (DataExpiracao <= DateTime.Now)
            {
                throw new DomainException("A data de expiração deve ser futura.");
            }
        }
    }
}
