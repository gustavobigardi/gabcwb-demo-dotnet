using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.Sqlite;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class NcmRepository
    {
        private string _file = "DataSource=" + System.Environment.CurrentDirectory + "\\database.sqlite";

        public async Task<List<Ncm>> List()
        {
            using (SqliteConnection connection = new SqliteConnection(_file))
            {
                connection.Open();
                var result = (await connection.QueryAsync<Ncm>("SELECT * FROM ncm")).ToList();
                connection.Close();
                return result;
            }
        }

        public async Task<Ncm> GetByFullCode(string code)
        {
            Console.WriteLine(_file);

            using (SqliteConnection connection = new SqliteConnection(_file))
            {
                try 
                {
                    connection.Open();
                    var result = (await connection.QuerySingleAsync<Ncm>("SELECT * FROM ncm WHERE Code = @Code", new { Code = code }));
                    connection.Close();
                    return result;
                }
                catch (InvalidOperationException) {
                    return null;
                }
                
            }
        }
    }
}