using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.SEGUsuarioSpecification
{
    public class NomeDeveTerMinimo3Caracteres : ISpecification<SEGUsuario>
    {
        public bool IsSatisfiedBy(SEGUsuario entity)
        {
            return false;
        }
    }
}
