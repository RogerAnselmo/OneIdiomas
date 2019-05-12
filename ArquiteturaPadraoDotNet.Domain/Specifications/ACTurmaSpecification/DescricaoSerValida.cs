using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACTurmaSpecification
{
    public class DescricaoSerValida : ISpecification<ACTurma>
    {
        public bool IsSatisfiedBy(ACTurma entity)
            => !string.IsNullOrEmpty(entity.Descricao) && entity.Descricao.Length <= 400;
    }
}
