using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACAlunoResponsavelSpecification
{
    public class CodigoAlunoDeveSerMaiorQueZero : ISpecification<ACAlunoResponsavel>
    {
        public bool IsSatisfiedBy(ACAlunoResponsavel entity) => entity.CodigoAluno > 0;
    }
}
