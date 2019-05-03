using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.GEEnderecoSpecification
{
    public class StatusDeveSerValido : ISpecification<GEEndereco>
    {
        readonly string ativo = "A";
        readonly string inativo = "I";


        public bool IsSatisfiedBy(GEEndereco entity)
            => entity.flAtivo.Length == 1
                && (entity.flAtivo.Equals(ativo) || entity.flAtivo.Equals(inativo));
    }
}
