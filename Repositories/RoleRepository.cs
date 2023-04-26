using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class RoleRepository
    {

        private readonly SqlConnection _connection;
        public RoleRepository(SqlConnection connection) => _connection = connection;

        public Role GetAll(int id) => _connection.Get<Role>(id);
        public IEnumerable<Role> GetAll() => _connection.GetAll<Role>();
    }
}