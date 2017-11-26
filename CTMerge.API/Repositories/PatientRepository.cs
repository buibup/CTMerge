using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CTMerge.API.ViewModel;
using static CTMerge.API.Enums;

namespace CTMerge.API.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        public PatientRepository()
        {
            GlobalConfig.InitializeConnections(DatabaseType.MySql);
        }
        public Task<IEnumerable<PatientVM>> FindPatient(string search, Enums.SearchType type)
        {
            return Task.Run( () => GlobalConfig.Connection.FindPatient(search, type));
        }
    }
}