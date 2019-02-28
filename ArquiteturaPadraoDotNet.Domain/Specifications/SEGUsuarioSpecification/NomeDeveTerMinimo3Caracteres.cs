using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Specifications.SEGUsuarioSpecification
{
    public class DeveTerUmNomeComNoMinimo3Caracteres : ISpecification<SEGUsuario>
    {
        public bool IsSatisfiedBy(SEGUsuario entity)
        {
            return false;
        }
    }
}
