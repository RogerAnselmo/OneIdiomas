using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.GETelefoneSpecification
{
    public class TelefoneDeveTerUmNumeroValido : ISpecification<GETelefone>
    {
        public bool IsSatisfiedBy(GETelefone entity) 
            => !string.IsNullOrEmpty(entity.NumeroTelefone) && entity.NumeroTelefone.Length <= 20;
    }
}
