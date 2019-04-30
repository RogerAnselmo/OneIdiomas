using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.SEGUsuarioSpecification
{
    public class NomeDeveTerAte200Caracteres : ISpecification<SEGUsuario>
    {
        public bool IsSatisfiedBy(SEGUsuario entity) 
            => !string.IsNullOrEmpty(entity.NomeCompleto) && entity.NomeCompleto.Length <= 200;
    }
}
