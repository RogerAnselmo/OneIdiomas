using One.Domain.Validation.Interface;

namespace One.Domain.Validation
{
    public class Rule<TEntity> : IRule<TEntity>
    {
        public ISpecification<TEntity> spec;
        public string ErrorMessage { get; }
        public TEntity entity;

        public Rule(ISpecification<TEntity> spec, string errorMessage, TEntity entity)
        {
            this.spec = spec;
            ErrorMessage = errorMessage;
            this.entity = entity;
        }

        public bool Validate()
        {
            return spec.IsSatisfiedBy(entity);
        }
    }
}
