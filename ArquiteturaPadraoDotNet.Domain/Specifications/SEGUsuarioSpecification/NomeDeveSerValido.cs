using One.Domain.Validation.Interface;
using One.Domain.Entities;

namespace One.Domain.Specifications.SEGUsuarioSpecification
{
    public class NomeDeveSerValido : ISpecification<SEGUsuario>
    {
        public bool IsSatisfiedBy(SEGUsuario entity)
        {
            return !string.IsNullOrEmpty(entity.NomeCompleto);
        }
    }
}
