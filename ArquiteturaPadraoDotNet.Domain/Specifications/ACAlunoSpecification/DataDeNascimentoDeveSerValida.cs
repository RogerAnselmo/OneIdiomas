using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACAlunoSpecification
{
    public class DataDeNascimentoDeveSerValida : ISpecification<ACAluno>
    {
        public bool IsSatisfiedBy(ACAluno entity)
        => entity.DataNascimento.Date > new DateTime(1900, 1, 1).Date
                   && entity.DataNascimento.Date <= DateTime.Today;
    }
}
