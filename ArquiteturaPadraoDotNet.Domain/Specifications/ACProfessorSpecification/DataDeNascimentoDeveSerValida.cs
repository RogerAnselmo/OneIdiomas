using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACProfessorSpecification
{
    public class DataDeNascimentoDeveSerValida : ISpecification<ACProfessor>
    {
        public bool IsSatisfiedBy(ACProfessor entity)
        => entity.DataNascimento > new DateTime(1900, 1, 1).Date
                   && entity.DataNascimento <= DateTime.Now.Date;
    }
}
