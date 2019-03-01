using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.GEEnderecoSpecification
{
    public class StatusDeveSerValido : ISpecification<GEEndereco>
    {
        public bool IsSatisfiedBy(GEEndereco entity)
        {
            return entity.flAtivo.Length == 1 
                && (
                    entity.flAtivo.Equals("A") ||//Ativo
                    entity.flAtivo.Equals("I")   //Inativo
                );
        }
    }
}
