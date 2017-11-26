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

        public IEnumerable<PatientVM> FindPatient(string search, SearchType type)
        {
            using (IDbConnection connection = mySqlConnection)
            {
                var p = new DynamicParameters();
                p.Add("@Search_Data", search);
                p.Add("@Type_Search", type.ToString());
                return connection.Query<PatientVM>("GetPatient", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public IEnumerable<PatientVisitVM> ReadAll()
        {
            throw new NotImplementedException();
        }

        public PatientVisitVM ReadOne(string search, SearchType searchType)
        {
            throw new NotImplementedException();
        }

        public PatientVisitVM Update(PatientVisitVM PatientVisit)
        {
            throw new NotImplementedException();
        }
    }
}