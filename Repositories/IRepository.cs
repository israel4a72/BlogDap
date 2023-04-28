using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task<int> AddAsync(T entity);
        void UpdateAsync(T entity);
        void RemoveAsync(T entity);
        void RemoveAsync(int id);
    }
}