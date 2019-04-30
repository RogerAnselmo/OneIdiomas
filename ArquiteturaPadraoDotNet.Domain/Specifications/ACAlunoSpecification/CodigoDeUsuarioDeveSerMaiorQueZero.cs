using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.ACAlunoSpecification
{
    public class CodigoDeUsuarioDeveSerMaiorQueZero : ISpecification<ACAluno>
    {
        public bool IsSatisfiedBy(ACAluno entity) => entity.CodigoUsuario > 0;
    }
}
