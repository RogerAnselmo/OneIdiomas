using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.GEUsuarioEnderecoSpecification
{
    public class CodigoUsuarioDeveSerMaiorQueZero : ISpecification<GEUsuarioEndereco>
    {
        public bool IsSatisfiedBy(GEUsuarioEndereco entity)
            => entity.CodigoEndereco > 0;
    }
}
