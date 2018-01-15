using System;
using System.Collections.Generic;
using CTMerge.API.ViewModel;
using MySql.Data.MySqlClient;
using System.Data;
using Dapper;
using System.Linq;
using static CTMerge.API.Enums;
using CTMerge.API.Models;
using System.Threading.Tasks;

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

        private PatientVM GetPatientBCTByHN(string hn)
        {
            try
            {
                using (IDbConnection connection = mySqlConnection)
                {
                    var p = new DynamicParameters();
                    p.Add("@Search_Data", hn);
                    var pt = connection.QueryAsync<PatientData>("GetPatient", p, commandType: CommandType.StoredProcedure).Result.FirstOrDefault();

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

                    return ptvm;
                }
            }
            catch (Exception)
            {

                return new PatientVM();
            }
            
        }

        public IEnumerable<PatientVM> GetPatientBCT(string search)
        {
            using (IDbConnection connection = mySqlConnection)
            {
                var data = new List<PatientVM>();
                var p = new DynamicParameters();
                p.Add("@Search_Data", search);
                var patients = connection.QueryAsync<PatientData>("GetPatient", p, commandType: CommandType.StoredProcedure).Result.ToList();

                foreach (var pt in patients)
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

        public PatientVisitVM GetPatientBCTVisit(string hn)
        {
            var pEpi = new DynamicParameters();
            pEpi.Add("@_HN", hn);

            using (IDbConnection connection = mySqlConnection)
            {
                var ptvm = GetPatientBCTByHN(hn);
                var epiVMList = connection.QueryAsync<EpisodeVM>("GetAllEpisodeByHN", pEpi, commandType: CommandType.StoredProcedure).Result.ToList();

                var ptVisitVm = new PatientVisitVM()
                {
                    PatientVM = ptvm,
                    EpisodeList = epiVMList
                };

                return ptVisitVm;
            }
        }

        public bool PatientMerge(string BCT_HN, string SCT_HN, string USERNAME, string FULLNAME, string STATUS)
        {
            bool isMerge = false;
            var p = new DynamicParameters();
            p.Add("@_BCT_HN", BCT_HN);
            p.Add("@_SCT_HN", SCT_HN);
            p.Add("@_USERNAME", USERNAME);
            p.Add("@_FULLNAME", FULLNAME);
            p.Add("@_STATUS", STATUS);
            using (IDbConnection connection = mySqlConnection)
            {
                try
                {
                    isMerge = connection.QueryAsync<bool>("MergePatient", p, commandType: CommandType.StoredProcedure).Result.FirstOrDefault();
                }
                catch (Exception e)
                {

                    return isMerge;
                }

            }

            return isMerge;
        }

        public bool HasPatient(string SCT_HN)
        {
            bool hasPatient = false;
            var p = new DynamicParameters();
            p.Add("@_SCT_HN", SCT_HN);
            using (IDbConnection connection = mySqlConnection)
            {
                try
                {
                    hasPatient = connection.QueryAsync<bool>("HasPatient", p, commandType: CommandType.StoredProcedure).Result.FirstOrDefault();
                }
                catch (Exception e)
                {

                    return hasPatient;
                }

            }

            return hasPatient;
        }

        public bool MergedLog(PatientMergedLogVM log)
        {

            var p = new DynamicParameters();
            p.Add("@_BCT_HN", log.BCT_HN);
            p.Add("@_SCT_HN", log.SCT_HN);
            p.Add("@_UserId", log.User.SSUSR_Initials);
            p.Add("@_UserName", log.User.SSUSR_Name);
            p.Add("@_Status", log.Status);

            using (IDbConnection connection = mySqlConnection)
            {
                try
                {
                    connection.QueryAsync("MergedLog", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception e)
                {
                }

            }
            
            return false;
        }

        public bool IsSecurityGroupAllow(string groupName)
        {
            bool isAllow = false;
            var p = new DynamicParameters();
            p.Add("@_GRPNAME", groupName);
            using (IDbConnection connection = mySqlConnection)
            {
                try
                {
                    isAllow = connection.QueryAsync<bool>("isSecurityGroupAllow", p, commandType: CommandType.StoredProcedure).Result.FirstOrDefault();
                }
                catch //(Exception e)
                {

                    return isAllow;
                }

            }

            return isAllow;
        }
    }
}
