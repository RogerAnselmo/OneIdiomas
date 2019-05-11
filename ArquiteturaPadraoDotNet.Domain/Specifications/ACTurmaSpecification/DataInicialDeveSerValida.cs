using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACTurmaSpecification
{
    public class DataInicialDevSerValida : ISpecification<ACTurma>
    {
        public bool IsSatisfiedBy(ACTurma entity)
            => entity.DataInicio > DateTime.MinValue && entity.DataInicio < DateTime.MaxValue;
    }
}
