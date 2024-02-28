using Dapper;
using ExternalServiceApi.Core.Contracts;
using ExternalServiceApi.Core.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalServiceApi.Infra.Data
{
 
    public class UserDataRepository : RepositoryBase<UsuariosParceiro>, IUserDataRepository
    {
        public UserDataRepository(IConfiguration configuration) : base(configuration) { }

        //public async Task<UsuariosParceiro> GetById(int userId)
        //{
        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        await connection.OpenAsync();
        //
        //        string query = "SELECT * FROM UsuariosParceiros WHERE Id = @UserId";
        //        return await connection.QueryFirstOrDefaultAsync<UsuariosParceiro>(query, new { UserId = userId });
        //    }
        //}
        //
        //public async Task<IEnumerable<UsuariosParceiro>> GetAll()
        //{
        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        await connection.OpenAsync();
        //
        //        string query = "SELECT * FROM UsuariosParceiros";
        //        return await connection.QueryAsync<UsuariosParceiro>(query);
        //    }
        //}


    }
}
