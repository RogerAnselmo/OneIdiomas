using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Specifications.ACAlunoSpecification
{
    public class CodigoDeUsuarioDeveSerMaiorQueZero : ISpecification<ACAluno>
    {
        public bool IsSatisfiedBy(ACAluno entity)
        {
            throw new NotImplementedException();
        }
    }
}
