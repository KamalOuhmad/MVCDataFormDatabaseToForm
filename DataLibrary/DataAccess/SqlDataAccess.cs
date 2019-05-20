using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace DataLibrary.DataAccess
{
    public static class SqlDataAccess
    {
        public static string GetConnectionString(string ConnectionName = "MVCDemoDB")
        {
            return ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string Sql)
        {
            using(IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(Sql).ToList();
            }
        }

        public static int SaveData<T>(string Sql, T Data)
        {
            using(IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(Sql, Data);
            }
        }
    
    }
}
