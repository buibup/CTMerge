using CTMerge.API.DataAccess;
using System.Configuration;
using static CTMerge.API.Enums;

namespace CTMerge.API
{
    public class GlobalConfig
    {
        public static IMySqlDataConnection MySqlConnection { get; private set; }
        public static ICacheDataConnection CacheConnection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if(db == DatabaseType.MySql)
            {
                MySqlConnector mySql = new MySqlConnector();
                MySqlConnection = mySql; 
            }else if(db == DatabaseType.Cache)
            {
                CacheConnector cache = new CacheConnector();
                CacheConnection = cache;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}