using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<int> AddAsync(T entity)
        {
            return await _connection.InsertAsync<T>(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _connection.GetAllAsync<T>();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _connection.GetAsync<T>(id);
        }

        public async void RemoveAsync(T entity)
        {
            await _connection.DeleteAsync<T>(entity);
        }

        public async void RemoveAsync(int id)
        {
            var entity = await _connection.GetAsync<T>(id);
            await _connection.DeleteAsync<T>(entity);
        }

        public async void UpdateAsync(T entity)
        {
            await _connection.UpdateAsync<T>(entity);
        }
    }
}