using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACAlunoSpecification
{
    public class RGDeveSerValido : ISpecification<ACAluno>
    {
        public bool IsSatisfiedBy(ACAluno entity) 
            => !string.IsNullOrEmpty(entity.RG) && entity.RG.Length <= 20;
    }
}
