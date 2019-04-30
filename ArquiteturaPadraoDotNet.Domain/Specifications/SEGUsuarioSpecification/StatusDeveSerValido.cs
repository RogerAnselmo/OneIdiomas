using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.SEGUsuarioSpecification
{
    public class StatusDeveSerValido : ISpecification<SEGUsuario>
    {
        public bool IsSatisfiedBy(SEGUsuario entity) 
            => !string.IsNullOrEmpty(entity.flAtivo)
                && entity.flAtivo.Length == 1
                && (entity.flAtivo.Equals("A") || entity.flAtivo.Equals("I"));
    }
}
