using One.Domain.Validation.Interface;

namespace One.Domain.Validation
{
    public class Validator<TEntity> : IValidator<TEntity> where TEntity : class
    {
        public ValidationResult validationResult;
        public TEntity entity;

        protected Validator()
        {
            validationResult = new ValidationResult();
        }
        public virtual ValidationResult Validate()
        {
            return validationResult;
        }

        protected virtual void Add(string name, IRule<TEntity> rule)
        {
            validationResult.Add(name, rule.ErrorMessage, rule.Validate());
        }
    }
}
