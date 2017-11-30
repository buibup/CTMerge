using System;
using System.Collections.Generic;
using CTMerge.API.ViewModel;
using MySql.Data.MySqlClient;
using System.Data;
using Dapper;
using System.Linq;
using static CTMerge.API.Enums;

namespace CTMerge.API.DataAccess
{
    public class MySqlConnector : IDataConnection
    {
        private const string db = "MySql";
        private MySqlConnection mySqlConnection;
        public MySqlConnector()
        {
            mySqlConnection = new MySqlConnection(GlobalConfig.CnnString(db));
        }

        public IEnumerable<PatientVM> GetPatient(string search)
        {
            using (IDbConnection connection = mySqlConnection)
            {
                var p = new DynamicParameters();
                p.Add("@Search_Data", search);
                return connection.Query<PatientVM>("GetPatient", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public IEnumerable<PatientVisitVM> GetPatientVisit(string hn)
        {
            throw new NotImplementedException();
        }

        public bool MergePatient(string oldHN, string newHN)
        {
            throw new NotImplementedException();
        }
    }
}
