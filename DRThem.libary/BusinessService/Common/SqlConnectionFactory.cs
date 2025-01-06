﻿using DrThem.Libary.BusinessObject;
using System.Data.SqlClient;

namespace DrThem.Libary.BusinessService.Common
{
    public class SqlConnectionFactory : BaseMapInstance<SqlConnectionFactory>
    {

        public string HostAddress { get; set; }

        public string DatabaseName { get; set; }

        public string EncryptUser { get; set; }

        public string EncryptPass { get; set; }

        public string ApplicationName { get; set; }

        public bool UseAdAccount { get; set; }// sử dụng kết nối qua IIS App Identity
        public string ConnectionString { get; set; }

        public SqlConnectionFactory()
        {
            ApplicationName = "DRThem";
        }
        public SqlConnection GetConnection()
        {
            SqlConnection connection = null;
            try
            {
                string sqlConnectionString = "Data Source=" + HostAddress + ";Initial Catalog=" + DatabaseName +
     ";User ID=" + EncryptUser +
     ";Password=" + EncryptPass +
     //";MultipleActiveResultSets=true" + //bỏ do máy sẽ tái sử dụng transaction 
     ";Application Name=" + ApplicationName + ";";
                ConnectionString = sqlConnectionString;
                connection = new SqlConnection(sqlConnectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                _logger.Error(string.Format("Failed to connect to database server:{0} - database:{1} - user:{2}",
                     HostAddress, DatabaseName,
                     EncryptUser), ex);
                throw;
            }

            return connection;
        }
    }
}