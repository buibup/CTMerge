using CTMerge.API.DataAccess;
using CTMerge.API.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using InterSystems.Data.CacheClient;
using Dapper;

namespace CTMerge.API.BusinessLogic
{
    public class AuthenticationBL
    {
        private const string db = "Cache";
        private OdbcConnection cacheConnection;
        private IMySqlDataConnection _mySqlConnection;

        public AuthenticationBL()
        {
            cacheConnection = new OdbcConnection(GlobalConfig.CnnString(db));
            _mySqlConnection = new MySqlConnector();
        }

        public bool Checkpassword(string username, string password)
        {
            bool result = false;
            var PassEncryp = CTMerge.API.DataAccess.CacheLogonProcessor.TrakCareEnCryptPass(password);

            var userTC = new User();

            using (IDbConnection connection = cacheConnection)
            {
                userTC = connection.QueryFirstOrDefaultAsync<User>(DBCacheQuery.Logon(), new { SSUSR_Initials = username }).Result;
            }

            if (userTC != null)
            {
                if (PassEncryp == userTC.SSUSR_Password)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }


        public GetUserResult GetUserResult(string username, string password)
        {
            GetUserResult result = new GetUserResult();
            var PassEncryp = CTMerge.API.DataAccess.CacheLogonProcessor.TrakCareEnCryptPass(password);

            var userTC = new UserResult();
            using (IDbConnection connection = cacheConnection)
            {
                userTC = connection.QueryFirstOrDefaultAsync<UserResult>(DBCacheQuery.GetUserResult(), new { SSUSR_Initials = username }).Result;
            }

            if (userTC != null)
            {
                if (PassEncryp == userTC.SSUSR_Password)
                {
                    bool isAllow = _mySqlConnection.IsSecurityGroupAllow(userTC.SSGRP_Desc);

                    result.SSUSR_Initials = userTC.SSUSR_Initials;
                    result.SSUSR_Name = userTC.SSUSR_Name;
                    result.SSGRP_Desc = userTC.SSGRP_Desc;
                    result.CTLOC_Desc = userTC.CTLOC_Desc;
                    result.IsGroupAllow = isAllow;
                }
            }


            return result;
        }


    }
}