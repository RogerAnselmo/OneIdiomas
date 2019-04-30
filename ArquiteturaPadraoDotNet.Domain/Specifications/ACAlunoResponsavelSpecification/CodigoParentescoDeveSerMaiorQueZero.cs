using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACAlunoResponsavelSpecification
{
    public class CodigoParentescoDeveSerMaiorQueZero: ISpecification<ACAlunoResponsavel>
    {
        public bool IsSatisfiedBy(ACAlunoResponsavel entity) => entity.CodigoParentesco > 0;
    }
}
