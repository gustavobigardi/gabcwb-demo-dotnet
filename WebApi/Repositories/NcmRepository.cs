using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class NcmRepository
    {
        private readonly SqlConnection _connection;

        public NcmRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<Ncm>> List()
        {
            return (await _connection.QueryAsync<Ncm>("SELECT * FROM Ncm")).ToList();
        }

        public async Task<Ncm> GetByFullCode(string code)
        {
            return (await _connection.QuerySingleAsync<Ncm>("SELECT * FROM Ncm WHERE SubItem = @Code", new { Code = code }));
        }
    }
}