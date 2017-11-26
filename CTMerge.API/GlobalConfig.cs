using CTMerge.API.DataAccess;
using System.Configuration;
using static CTMerge.API.Enums;

namespace CTMerge.API
{
    public class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if(db == DatabaseType.MySql)
            {
                MySqlConnector mySql = new MySqlConnector();
                Connection = mySql; 
            }else if(db == DatabaseType.Cache)
            {
                CacheConnector cache = new CacheConnector();
                Connection = cache;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}