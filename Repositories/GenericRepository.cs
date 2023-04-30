using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly SqlConnection _connection;
        public GenericRepository(SqlConnection connection)
        {
            _connection = connection;
        }
        public long Add(T entity)
        {
            return _connection.Insert<T>(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _connection.GetAll<T>();
        }

        public T Get(int id)
        {
            return _connection.Get<T>(id);
        }

        public void Remove(T entity)
        {
            _connection.Delete<T>(entity);
        }

        public void Remove(int id)
        {
            var entity = _connection.Get<T>(id);
            _connection.Delete<T>(entity);
        }

        public void Update(T entity)
        {
            _connection.Update<T>(entity);
        }
    }
}