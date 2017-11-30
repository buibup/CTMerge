using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CTMerge.API.ViewModel;
using static CTMerge.API.Enums;
using CTMerge.API.DataAccess;

namespace CTMerge.API.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private IDataConnection _cacheConnection;
        private IDataConnection _mySqlConnection;

        public PatientRepository()
        {
            _cacheConnection = new CacheConnector();
            _mySqlConnection = new MySqlConnector();
        }


        public Task<IEnumerable<PatientVM>> GetPatient(string search)
        {
            return Task.Run(() => _mySqlConnection.GetPatient(search));
        }
    }
}
