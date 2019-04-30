using One.Domain.Validation.Interface;
using System.Linq;

namespace One.Domain.Validation
{
    public class Validator<TEntity> : IValidator<TEntity> where TEntity : class
    {
        public ValidationResults validationResult;
        public TEntity entity;

        protected Validator() => validationResult = new ValidationResults(false, "");

        public virtual ValidationResults Validate()
        {
            validationResult = validationResult.Erros
                               .Where(erro => !erro.IsValid)
                               .Select(erro => erro)
                               .FirstOrDefault() ?? new ValidationResults(true, "");


            return validationResult;
        }

        protected virtual void Add(string name, IRule<TEntity> rule)
        {
            validationResult.Add(name, rule.ErrorMessage, rule.Validate());
        }
    }
}
