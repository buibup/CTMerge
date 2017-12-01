using System;
using System.Collections.Generic;
using CTMerge.API.ViewModel;
using MySql.Data.MySqlClient;
using System.Data;
using Dapper;
using System.Linq;
using static CTMerge.API.Enums;
using CTMerge.API.Models;

namespace CTMerge.API.DataAccess
{
    public class MySqlConnector : IMySqlDataConnection
    {
        private const string db = "MySql";
        private MySqlConnection mySqlConnection;
        public MySqlConnector()
        {
            mySqlConnection = new MySqlConnection(GlobalConfig.CnnString(db));
        }

        public IEnumerable<PatientVM> GetPatientBCT(string search)
        {
            using (IDbConnection connection = mySqlConnection)
            {
                var data = new List<PatientVM>();
                var p = new DynamicParameters();
                p.Add("@Search_Data", search);
                var patients = connection.Query<PatientData>("GetPatient", p, commandType: CommandType.StoredProcedure).ToList();

                foreach(var pt in patients)
                {
                    var ptvm = new PatientVM();
                    var patient = new BasePatientVM()
                    {
                        HN = pt.HN,
                        TitleName = pt.TitileName,
                        FirstName = pt.FirstName,
                        MiddleName = pt.MiddleName,
                        LastName = pt.LastName,
                        DOB = pt.DOB,
                        SexCode = pt.SexCode,
                        SexDesc = pt.SexDesc,
                        IDCard = pt.IDCard
                    };
                    ptvm.Patient = patient;
                    ptvm.SCT_HN = pt.SCT_HN;

                    data.Add(ptvm);
                }

                return data;
            }
        }

        public IEnumerable<PatientMergeVM> GetPatientMerge(string hn)
        {
            throw new NotImplementedException();
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
