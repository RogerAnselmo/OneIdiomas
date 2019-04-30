using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Specifications.SEGUsuarioSpecification
{
    public class LoginDeveTerNoMaximo100Caracteres : ISpecification<SEGUsuario>
    {
        public bool IsSatisfiedBy(SEGUsuario entity) 
            => !string.IsNullOrEmpty(entity.Login) && entity.Login.Length <= 100;
    }
}
