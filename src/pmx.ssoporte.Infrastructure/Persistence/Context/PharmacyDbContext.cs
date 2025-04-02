using Microsoft.Extensions.Configuration;
using System.Data;
using Npgsql;

namespace pmx.ssoporte.Infrastructure.Persistence.Context
{
    public class PharmacyDbContext
    {
        private readonly IConfiguration _configuration;

        public PharmacyDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection() => new NpgsqlConnection(_configuration.GetConnectionString("PharmacyConnection"));
    }
}
