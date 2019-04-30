using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.GEEnderecoSpecification
{
    public class CEPDeveSerValido : ISpecification<GEEndereco>
    {
        public bool IsSatisfiedBy(GEEndereco entity) 
            => !string.IsNullOrEmpty(entity.Cep) && entity.Cep.Length <= 10;
    }
}
