namespace One.Domain.Validation.Interface
{
    public interface IValidator<in TEntity>
    {
        ValidationResults Validate();
    }
}
