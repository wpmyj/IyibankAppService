using IyibankAppService.Utils.Config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace IyibankAppService.Data.Config
{
    public static class DbFactory
    {
        private static readonly string ConnectionString = ConfigHelper.GetConnectionString("Iyibank");
        private static readonly IDbConnection DbConnection = new MySqlConnection(ConnectionString);

        public static IDbConnection GetNewConnection()
        {
            var connection = ConnectionString;
            //var con = @"server=114.215.158.176;port=5002;database=oemmis_dev;uid=oemmis_dev;pwd=000000;SslMode=None";
            return new MySqlConnection(connection);
        }
    }
}
