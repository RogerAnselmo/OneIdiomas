namespace One.Domain.Validation.Interface
{
    public interface ISpecification<in TEntity>
    {
        bool IsSatisfiedBy(TEntity entity);
    }
}
