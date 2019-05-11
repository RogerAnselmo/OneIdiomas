using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Specifications.ACTurmaSpecification
{
    public class CodigoProfessorDeveSerMaiorQueZero : ISpecification<ACTurma>
    {
        public bool IsSatisfiedBy(ACTurma entity) => entity.CodigoProfessor > 0;
    }
}
