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
        private ICacheDataConnection _cacheConnection;
        private IMySqlDataConnection _mySqlConnection;

        public PatientRepository()
        {
            _cacheConnection = new CacheConnector();
            _mySqlConnection = new MySqlConnector();
        }


        public Task<IEnumerable<PatientVM>> GetPatientBCT(string search)
        {
            return Task.Run(() => _mySqlConnection.GetPatientBCT(search));
        }

        public Task<IEnumerable<BasePatientVM>> GetPatientSCTByHN(string hn)
        {
            return Task.Run(() => _cacheConnection.GetPatient(hn));
        }

        public Task<IEnumerable<BasePatientVM>> GetPatientSCTByName(string firstName, string lastName)
        {
            return Task.Run(() => _cacheConnection.GetPatient(firstName, lastName));
        }

        public Task<IEnumerable<PatientVisitVM>> GetPatientVisit(string hn)
        {
            throw new NotImplementedException();
        }
    }
}
