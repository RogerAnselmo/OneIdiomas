using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.ACAlunoResponsavelSpecification
{
    public class CodigoResponsavelDeveSerMaiorQueZero : ISpecification<ACAlunoResponsavel>
    {
        public bool IsSatisfiedBy(ACAlunoResponsavel entity) => entity.CodigoResponsavel > 0;
    }
}
