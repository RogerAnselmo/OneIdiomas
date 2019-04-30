using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACAlunoSpecification
{
    public class DiaVencimentoDeveSerValido : ISpecification<ACAluno>
    {
        public bool IsSatisfiedBy(ACAluno entity) 
            => entity.DiaVencimento > 0 && entity.DiaVencimento < 25;
    }
}
