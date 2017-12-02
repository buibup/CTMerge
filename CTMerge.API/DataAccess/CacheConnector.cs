using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CTMerge.API.ViewModel;
using CTMerge.API.Models;
using InterSystems.Data.CacheClient;
using Dapper;
using System.Data;

namespace CTMerge.API.DataAccess
{
    public class CacheConnector : ICacheDataConnection
    {
        private const string db = "Cache";
        private CacheConnection cacheConnection;
        public CacheConnector()
        {
            cacheConnection = new CacheConnection(GlobalConfig.CnnString(db));
        }

        public BasePatientVM GetPatientByHN(string hn)
        {
            var data = new BasePatientVM();

            using (IDbConnection connection = cacheConnection)
            {
                data = connection.QueryFirstOrDefaultAsync<BasePatientVM>(DBCacheQuery.GetPatientByHN(), new { PAPMI_No = hn }).Result;
            }

            return data;
        }

        public IEnumerable<BasePatientVM> GetPatient(string hn)
        {
            var data = new List<BasePatientVM>();

            int _hn = 0;
            var query = "";
            var p = new DynamicParameters();
            var trySearch = hn.Replace("-", "");

            if(int.TryParse(trySearch, out _hn))
            {
                query = DBCacheQuery.GetPatientByHN();
                p.AddDynamicParams(new { PAPMI_No = _hn + "%" });
            }
            

            using (IDbConnection connection = cacheConnection)
            {
                data = connection.QueryAsync<BasePatientVM>(query, p).Result.ToList();
            }

            return data;
        }

        public IEnumerable<BasePatientVM> GetPatient(string firstName, string lastName)
        {
            var data = new List<BasePatientVM>();
            var p = PatientDynamicParameters(firstName, lastName);

            using (IDbConnection connection = cacheConnection)
            {
                data = connection.QueryAsync<BasePatientVM>(DBCacheQuery.GetPatientByName(firstName, lastName), p).Result.ToList();    
            }

            return data;
        }

        private DynamicParameters PatientDynamicParameters(string firstName, string lastName)
        {
            var p = new DynamicParameters();

            var _firstName = $"{firstName}%";
            var _lastName = $"{lastName}%";

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                p.AddDynamicParams(new { PAPMI_Name = _firstName, PAPMI_Name2 = _lastName });
            }
            else if (!string.IsNullOrEmpty(firstName))
            {
                p.AddDynamicParams(new { PAPMI_Name = _firstName });
            }
            else if (!string.IsNullOrEmpty(lastName))
            {
                p.AddDynamicParams(new { PAPMI_Name2 = _lastName });
            }

            return p;
        }
    }
}
