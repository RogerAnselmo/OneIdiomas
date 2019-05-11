using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACTurmaSpecification
{
    public class DataInicialDeveSerMenorQueDataFinal : ISpecification<ACTurma>
    {
        public bool IsSatisfiedBy(ACTurma entity)
            => entity.DataInicio <= entity.DataFim;
    }
}
