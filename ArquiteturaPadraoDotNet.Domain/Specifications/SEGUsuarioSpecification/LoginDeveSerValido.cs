using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.SEGUsuarioSpecification
{
    public class SEGUsuarioDeveTerLoginValidoSpecification : ISpecification<SEGUsuario>
    {
        public bool IsSatisfiedBy(SEGUsuario entity)
        {
            return false;
        }
    }
}
