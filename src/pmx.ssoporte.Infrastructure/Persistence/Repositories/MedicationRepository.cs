using pmx.ssoporte.Application.Interfaces.FharmacyMedication;
using pmx.ssoporte.Domain.Entities;
using pmx.ssoporte.Infrastructure.Persistence.Context;
using Dapper;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pmx.ssoporte.Infrastructure.Persistence.Repositories
{
    public class MedicationRepository : IMedicationRepository
    {
        private readonly PharmacyDbContext _context;

        public MedicationRepository(PharmacyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Medication>> GetAllMedicationsAsync()
        {
           using (IDbConnection dbConnection = _context.CreateConnection())
            {
                string sqlQuery = "SELECT * FROM Medications";
                return await dbConnection.QueryAsync<Medication>(sqlQuery);
            }
        }
    }
}
