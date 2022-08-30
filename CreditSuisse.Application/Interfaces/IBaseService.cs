namespace CreditSuisse.Application.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
