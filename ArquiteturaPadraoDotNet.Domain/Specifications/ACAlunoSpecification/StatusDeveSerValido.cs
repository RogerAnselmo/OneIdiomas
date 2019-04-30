using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.ACAlunoSpecification
{
    public class StatusDeveSerValido : ISpecification<ACAluno>
    {
        public bool IsSatisfiedBy(ACAluno entity) 
            => !string.IsNullOrEmpty(entity.flAtivo)
               && entity.flAtivo.Length == 1
               && (entity.flAtivo.Equals("A") || entity.flAtivo.Equals("I"));
    }
}
