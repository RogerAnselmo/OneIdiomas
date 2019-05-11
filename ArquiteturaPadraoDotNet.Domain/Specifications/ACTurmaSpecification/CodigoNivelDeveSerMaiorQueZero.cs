using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.ACTurmaSpecification
{
    public class CodigoNivelDeveSerMaiorQueZero : ISpecification<ACTurma>
    {
        public bool IsSatisfiedBy(ACTurma entity) => entity.CodigoNivel > 0;
    }
}
