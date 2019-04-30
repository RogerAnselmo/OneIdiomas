using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.GEGETelefoneSpecification
{
    public class DeveTerUmTipoDeTelefoneValido : ISpecification<GETelefone>
    {
        public bool IsSatisfiedBy(GETelefone entity) 
            => entity.CodigoTipoTelefone > 0;
    }
}
