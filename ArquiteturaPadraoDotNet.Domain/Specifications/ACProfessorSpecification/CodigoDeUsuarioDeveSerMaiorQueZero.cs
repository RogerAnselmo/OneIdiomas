using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.ACProfessorSpecification
{
    public class CodigoDeUsuarioDeveSerMaiorQueZero : ISpecification<ACProfessor>
    {
        public bool IsSatisfiedBy(ACProfessor entity) => entity.CodigoUsuario > 0;
    }
}
