using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Specifications.GEEnderecoSpecification
{
    public class NumeroDeveSerValido : ISpecification<GEEndereco>
    {
        public bool IsSatisfiedBy(GEEndereco entity)
            => (entity.Numero != null && entity.Numero.Length <= 5);
    }
}
