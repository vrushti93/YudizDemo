using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace YudizPractical.Repositories
{
    public abstract class BaseRepository
    {
        private readonly IConfiguration _configuration;

        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration; 
        }

        public IDbConnection CreateConenction()
        {
            return new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
