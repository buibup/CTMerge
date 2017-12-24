using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CTMerge.API.ViewModel;
using static CTMerge.API.Enums;
using CTMerge.API.DataAccess;
using CTMerge.API.Models;

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

        public Task<PatientVisitVM> GetPatientBCTVisit(string hn)
        {
            return Task.Run(() => _mySqlConnection.GetPatientBCTVisit(hn));
        }

        public Task<bool> PatientMerge(string BCT_HN, string SCT_HN)
        {
            return Task.Run(() => _mySqlConnection.PatientMerge(BCT_HN, SCT_HN));
        }

        public Task<bool> HasPatient(string SCT_HN)
        {
            return Task.Run(() => _mySqlConnection.HasPatient(SCT_HN));
        }

        public Task<bool> MergedLog(PatientMergedLogVM log)
        {
            var userTC = new User
            {
                SSUSR_Initials = log.User.SSUSR_Initials,
                SSUSR_Password = log.User.SSUSR_Password
            };

            var logon = _cacheConnection.LogonTrakCare(userTC);

            if (logon.Item1)
            {
                Task.Run(() => _mySqlConnection.MergedLog(log));
            }

            return Task.Run(() => logon.Item1);
        }

    }
}
