using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACTurmaSpecification
{
    public class DataFinalDevSerValida : ISpecification<ACTurma>
    {
        public bool IsSatisfiedBy(ACTurma entity)
            => entity.DataFim > DateTime.MinValue && entity.DataFim < DateTime.MaxValue;
    }
}
