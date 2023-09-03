namespace CleanShop.Application.Services.Repositories
{
    public interface IQuery<T>
    {
        IQueryable<T> Query();
    }
}
