using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.GEEnderecoSpecification
{
    public class CodigoBairroDeveSerMaiorQueZero : ISpecification<GEEndereco>
    {
        public bool IsSatisfiedBy(GEEndereco entity)
        {
            return entity.CodigoBairro > 0;
        }
    }
}
