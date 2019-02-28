using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.SEGUsuarioSpecification
{
    public class LoginDeveTerNoMinimo3Caracteres : ISpecification<SEGUsuario>
    {
        public bool IsSatisfiedBy(SEGUsuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
