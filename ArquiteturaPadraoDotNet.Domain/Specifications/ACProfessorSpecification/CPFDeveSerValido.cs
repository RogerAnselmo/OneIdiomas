using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.ACProfessorSpecification
{
    public class CPFDeveSerValido : ISpecification<ACProfessor>
    {
        public bool IsSatisfiedBy(ACProfessor entity) 
            => !string.IsNullOrEmpty(entity.CPF) && entity.CPF.Length <= 11;
    }
}
