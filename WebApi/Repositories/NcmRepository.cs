using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class NcmRepository
    {
        private readonly IConfiguration _config;

        public NcmRepository(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<Ncm>> List()
        {
            using (SqlConnection connection = new SqlConnection(_config.GetConnectionString("TestContext")))
            {
                connection.Open();
                var result = (await connection.QueryAsync<Ncm>("SELECT * FROM Ncm")).ToList();
                connection.Close();
                return result;
            }
        }

        public async Task<Ncm> GetByFullCode(string code)
        {
            using (SqlConnection connection = new SqlConnection(_config.GetConnectionString("TestContext")))
            {
                connection.Open();
                var result = (await connection.QuerySingleAsync<Ncm>("SELECT * FROM Ncm WHERE Sub_Item = @Code", new { Code = code }));
                connection.Close();
                return result;
            }
        }
    }
}