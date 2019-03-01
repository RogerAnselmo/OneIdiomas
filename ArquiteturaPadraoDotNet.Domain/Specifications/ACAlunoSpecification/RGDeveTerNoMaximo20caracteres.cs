using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACAlunoSpecification
{
    public class RGDeveTerNoMaximo20caracteres : ISpecification<ACAluno>
    {
        public bool IsSatisfiedBy(ACAluno entity)
        {
            throw new NotImplementedException();
        }
    }
}
