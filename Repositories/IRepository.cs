namespace Blog.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        long Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Remove(int id);
    }
}