using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.GEGETelefoneSpecification
{
    public class StatusDeveSerValido : ISpecification<GETelefone>
    {
        public bool IsSatisfiedBy(GETelefone entity) 
            => entity.flAtivo.Length == 1
                && (
                    entity.flAtivo.Equals("A") ||//Ativo
                    entity.flAtivo.Equals("I")   //Inativo
                );
    }
}
