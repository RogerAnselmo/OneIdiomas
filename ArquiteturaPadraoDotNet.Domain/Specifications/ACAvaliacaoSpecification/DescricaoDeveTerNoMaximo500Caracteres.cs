using One.Domain.Entities;
using One.Domain.Validation.Interface;

namespace One.Domain.Specifications.ACAvaliacaoSpecification
{
    public class DescricaoDeveTerNoMaximo500Caracteres : ISpecification<ACAvaliacao>
    {
        public bool IsSatisfiedBy(ACAvaliacao entity)
        {
            return  entity.Descricao.Length <= 500;
        }
    }
}
