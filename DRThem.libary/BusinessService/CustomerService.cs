using DrThem.Libary.BusinessService.Common;
using log4net;
using System.Data.SqlClient;
using System.Reflection;

namespace DrThem.Libary.BusinessService
{
	public class CustomerService : BaseService<CustomerService>
    {
        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public class CustomerInfo
        {
            public int CustomerID { get; set; }
			public string PhoneNumber { get; set; }
			public string Password { get; set; }
            public string CustomerName { get; set; }
            public string DateOfBirth { get; set; }
			public string Email { get; set; }
			public string Sex { get; set; }
			public string CustomerAddress { get; set; }

			public void CopyValue(CustomerInfo info)
            {
                this.CustomerID = info.CustomerID;
				this.PhoneNumber = info.PhoneNumber;
				this.Password = info.Password;
				this.CustomerName = info.CustomerName;
				this.DateOfBirth = info.DateOfBirth;
				this.Email = info.Email;
				this.Sex = info.Sex;
				this.CustomerAddress = info.CustomerAddress;
            }
        }
        
        public CustomerInfo GetCustomer(SqlConnection connection, string phoneNumber)
        {
			CustomerInfo result = null;
            string strSQL = @"
            SELECT [CustomerID]
                  ,[PhoneNumber]
                  ,[Password]
                  ,[CustomerName]
                  ,[DateOfBirth]
                  ,[Email]
                  ,[Sex]
                  ,[CustomerAddress]
              FROM [dbo].[Customer] WHERE PhoneNumber = @PhoneNumber ";

            using (var command = new SqlCommand(strSQL, connection))
            {
                AddSqlParameter(command, "@PhoneNumber", phoneNumber, System.Data.SqlDbType.VarChar);

                WriteLogExecutingCommand(command);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
						result = new CustomerInfo();
						result.CustomerID = GetDbReaderValue<int>(reader["CustomerID"]);
                        result.PhoneNumber = GetDbReaderValue<string>(reader["PhoneNumber"]);
                        result.Password = GetDbReaderValue<string>(reader["Password"]);
                        result.CustomerName = GetDbReaderValue<string>(reader["CustomerName"]);
                        result.DateOfBirth = GetDbReaderValue<DateTime>(reader["DateOfBirth"]).ToString("dd/MM/yyyy");
                        result.Email = GetDbReaderValue<string>(reader["Email"]);
						result.Sex = GetDbReaderValue<string>(reader["Sex"]);
						result.CustomerAddress = GetDbReaderValue<string>(reader["CustomerAddress"]);
					}
				}
            }

            return result;
        }

        public bool Insert(SqlConnection connection, CustomerInfo infoInsert)
        {
            string strSQl = @"
            INSERT INTO [dbo].[Customer]
                   ([PhoneNumber]
                   ,[Password]
                   ,[CustomerName]
                   ,[DateOfBirth]
                   ,[Email]
                   ,[Sex]
                   ,[CustomerAddress])
             VALUES
                   (@PhoneNumber
                   ,@Password
                   ,@CustomerName
                   ,@DateOfBirth
                   ,@Email
                   ,@Sex
                   ,@CustomerAddress)";

            using (var command = new SqlCommand(strSQl, connection))
            {
                AddSqlParameter(command, "@PhoneNumber", infoInsert.PhoneNumber, System.Data.SqlDbType.VarChar);
                AddSqlParameter(command, "@Password", infoInsert.Password, System.Data.SqlDbType.VarChar);
                AddSqlParameter(command, "@CustomerName", infoInsert.CustomerName, System.Data.SqlDbType.NVarChar);
                AddSqlParameter(command, "@DateOfBirth", infoInsert.DateOfBirth, System.Data.SqlDbType.Date);
                AddSqlParameter(command, "@Email", infoInsert.Email, System.Data.SqlDbType.VarChar);
                AddSqlParameter(command, "@Sex", infoInsert.Sex, System.Data.SqlDbType.NVarChar);
				AddSqlParameter(command, "@CustomerAddress", infoInsert.CustomerAddress, System.Data.SqlDbType.NVarChar);

				WriteLogExecutingCommand(command);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool IsExistPhoneNumber(SqlConnection connection, string phoneNumber)
        {
            using (var command = new SqlCommand("SELECT [PhoneNumber] FROM [Customer] where PhoneNumber = @PhoneNumber", connection))
            {
                AddSqlParameter(command, "@PhoneNumber", phoneNumber, System.Data.SqlDbType.VarChar);
                WriteLogExecutingCommand(command);
                return command.ExecuteReader().HasRows;
            }
        }
        
        public bool Update(SqlConnection connection, CustomerInfo infoUpdate)
        {
            string strSql = @"
            UPDATE [dbo].[Customer]
               SET [Password] = @Password
                  ,[CustomerName] = @CustomerName
                  ,[DateOfBirth] = @DateOfBirth
                  ,[Email] = @Email
                  ,[Sex] = @Sex
                  ,[CustomerAddress] = @CustomerAddress
             WHERE CustomerID = @CustomerID ";
            using (var command = new SqlCommand(strSql, connection))
            {
                AddSqlParameter(command, "@CustomerID", infoUpdate.CustomerID, System.Data.SqlDbType.Int);
                AddSqlParameter(command, "@Password", infoUpdate.Password, System.Data.SqlDbType.VarChar);
                AddSqlParameter(command, "@CustomerName", infoUpdate.CustomerName, System.Data.SqlDbType.NVarChar);
                AddSqlParameter(command, "@DateOfBirth", infoUpdate.DateOfBirth, System.Data.SqlDbType.Date);
                AddSqlParameter(command, "@Email", infoUpdate.Email, System.Data.SqlDbType.VarChar);
                AddSqlParameter(command, "@Sex", infoUpdate.Sex, System.Data.SqlDbType.NVarChar);
				AddSqlParameter(command, "@CustomerAddress", infoUpdate.CustomerAddress, System.Data.SqlDbType.NVarChar);
				WriteLogExecutingCommand(command);
                return command.ExecuteNonQuery() > 0;
            }

        }
    }
}
