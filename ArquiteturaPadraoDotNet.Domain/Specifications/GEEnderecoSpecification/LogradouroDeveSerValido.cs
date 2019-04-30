using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Specifications.GEEnderecoSpecification
{
    public class LogradouroDeveSerValido : ISpecification<GEEndereco>
    {
        public bool IsSatisfiedBy(GEEndereco entity) 
            => !string.IsNullOrEmpty(entity.Logradouro) && entity.Logradouro.Length <= 500;
    }
}
