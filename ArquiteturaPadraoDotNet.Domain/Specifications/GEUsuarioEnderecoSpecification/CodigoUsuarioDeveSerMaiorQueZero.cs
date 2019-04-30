using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.GEUsuarioEnderecoSpecification
{
    public class CodigoEnderecoDeveSerMaiorQueZero : ISpecification<GEUsuarioEndereco>
    {
        public bool IsSatisfiedBy(GEUsuarioEndereco entity)
            => entity.CodigoUsuario > 0;
    }
}
