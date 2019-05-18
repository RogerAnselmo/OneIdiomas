using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACTurmaSpecification
{
    public class HoraInicialDevSerValida : ISpecification<ACTurma>
    {
        public bool IsSatisfiedBy(ACTurma entity)
            => entity.DataInicio > DateTime.MinValue && entity.DataInicio < DateTime.MaxValue;
    }
}
