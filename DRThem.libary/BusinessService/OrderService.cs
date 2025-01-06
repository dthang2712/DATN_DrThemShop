using DrThem.Libary.BusinessService.Common;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace DrThem.Libary.BusinessService
{
    public class OrderService : BaseService<OrderService>
    {
        [DataContract]
        public class OrderInfo
        {
            [DataMember]
            public int OrderID { get; set; }

            [DataMember]
            public int CustomerID { get; set; }

            [DataMember]
            public string? CustomerName { get; set; }

            [DataMember]
            public string? RecipientName { get; set; }

            [DataMember]
            public string? RecipientPhoneNumber { get; set; }

            [DataMember]
            public string? RecipientAddress { get; set; }

            [DataMember]
            public string? RecipientNote { get; set; }

            [DataMember]
            public DateTime? OrderDate { get; set; }

            [DataMember]
            public DateTime? ConfirmDate { get; set; }

            [DataMember]
            public DateTime? DeliveryDate { get; set; }

			[DataMember]
			public DateTime? CancelDate { get; set; }

			[DataMember]
			public string? ReasonCancel { get; set; }

            [DataMember]
            public int Status { get; set; }

			public void CopyValue(OrderInfo info)
			{
				this.OrderID = info.OrderID;
				this.CustomerID = info.CustomerID;
				this.CustomerName = info.CustomerName;
				this.RecipientName = info.RecipientName;
				this.RecipientPhoneNumber = info.RecipientPhoneNumber;
				this.RecipientAddress = info.RecipientAddress;
				this.RecipientNote = info.RecipientNote;
				this.OrderDate = info.OrderDate;
				this.ConfirmDate = info.ConfirmDate;
				this.DeliveryDate = info.DeliveryDate;
				this.CancelDate = info.CancelDate;
				this.ReasonCancel = info.ReasonCancel;
				this.Status = info.Status;
			}
		}

        public class OrderFilterInfo
        {
            public DateTime? DateFrom { get; set; }
            public DateTime? DateTo { get; set; }
            public int? CustomerID { get; set; }
            public int? Status { get; set; }
            public string? Search { get; set; }
        }

        public List<OrderInfo> GetListOrder(SqlConnection connection, OrderFilterInfo filter = null)
        {
            var result = new List<OrderInfo>();
            string strSQL = @"
            SELECT O.[OrderID]
				  ,O.[CustomerID]
				  ,C.[CustomerName]
				  ,O.[RecipientName]
				  ,O.[RecipientPhoneNumber]
				  ,O.[RecipientAddress]
				  ,O.[RecipientNote]
				  ,O.[OrderDate]
				  ,O.[ConfirmDate]
				  ,O.[DeliveryDate]
				  ,O.[CancelDate]
				  ,O.[ReasonCancel]
				  ,O.[Status]
			  FROM [dbo].[Order] O 
			LEFT JOIN Customer C on O.CustomerID = C.CustomerID WHERE 1=1 ";

            using (var command = new SqlCommand(strSQL, connection))
            {
                if (filter.DateFrom.HasValue && filter.DateTo.HasValue)
                {
                    command.CommandText += "and (O.OrderDate between @DateFrom and @DateTo) ";
                    AddSqlParameter(command, "@DateFrom", filter.DateFrom.GetValueOrDefault(), System.Data.SqlDbType.Date);
                    AddSqlParameter(command, "@DateTo", filter.DateTo.GetValueOrDefault(), System.Data.SqlDbType.Date);
                }

                if (filter.CustomerID.HasValue)
                {
                    command.CommandText += "and O.CustomerID = @CustomerID ";
                    AddSqlParameter(command, "@CustomerID", filter.CustomerID.GetValueOrDefault(), System.Data.SqlDbType.Int);
                }

                if (filter.Status.HasValue && filter.Status.GetValueOrDefault() != 4)
                {
                    command.CommandText += "and O.Status = @Status ";
                    AddSqlParameter(command, "@Status", filter.Status.GetValueOrDefault(), System.Data.SqlDbType.Int);
                }

                if (!string.IsNullOrEmpty(filter.Search))
                {
                    command.CommandText += "and OrderID like @strSearch";
                    AddSqlParameter(command, "@strSearch", "%" + filter.Search + "%", System.Data.SqlDbType.NVarChar);

                }
                WriteLogExecutingCommand(command);

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var item = new OrderInfo();
						item.OrderID = GetDbReaderValue<int>(reader["OrderID"]);
						item.CustomerID = GetDbReaderValue<int>(reader["CustomerID"]);
						item.CustomerName = GetDbReaderValue<string?>(reader["CustomerName"]);
						item.RecipientName = GetDbReaderValue<string?>(reader["RecipientName"]);
						item.RecipientPhoneNumber = GetDbReaderValue<string?>(reader["RecipientPhoneNumber"]);
						item.RecipientAddress = GetDbReaderValue<string?>(reader["RecipientAddress"]);
						item.RecipientNote = GetDbReaderValue<string?>(reader["RecipientNote"]);
						item.OrderDate = GetDbReaderValue<DateTime?>(reader["OrderDate"]);
						item.ConfirmDate = GetDbReaderValue<DateTime?>(reader["ConfirmDate"]);
						item.DeliveryDate = GetDbReaderValue<DateTime?>(reader["DeliveryDate"]);
						item.CancelDate = GetDbReaderValue<DateTime?>(reader["CancelDate"]);
						item.ReasonCancel = GetDbReaderValue<string?>(reader["ReasonCancel"]);
						item.Status = GetDbReaderValue<int>(reader["Status"]);

                        result.Add(item);
                    }
                }
            }

            return result;
        }

        public OrderInfo GetOrder(SqlConnection connection, int orderID)
        {
            OrderInfo result = null;
            string strSQL = @"
            SELECT O.[OrderID]
				  ,O.[CustomerID]
				  ,C.[CustomerName]
				  ,O.[RecipientName]
				  ,O.[RecipientPhoneNumber]
				  ,O.[RecipientAddress]
				  ,O.[RecipientNote]
				  ,O.[OrderDate]
				  ,O.[ConfirmDate]
				  ,O.[DeliveryDate]
				  ,O.[CancelDate]
				  ,O.[ReasonCancel]
				  ,O.[Status]
			  FROM [dbo].[Order] O 
			LEFT JOIN Customer C on O.CustomerID = C.CustomerID WHERE O.[OrderID] = @OrderID ";

            using (var command = new SqlCommand(strSQL, connection))
            {
                AddSqlParameter(command, "@OrderID", orderID, System.Data.SqlDbType.Int);

                WriteLogExecutingCommand(command);

				using (var reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						result = new OrderInfo();
						result.OrderID = GetDbReaderValue<int>(reader["OrderID"]);
						result.CustomerID = GetDbReaderValue<int>(reader["CustomerID"]);
						result.CustomerName = GetDbReaderValue<string?>(reader["CustomerName"]);
						result.RecipientName = GetDbReaderValue<string?>(reader["RecipientName"]);
						result.RecipientPhoneNumber = GetDbReaderValue<string?>(reader["RecipientPhoneNumber"]);
						result.RecipientAddress = GetDbReaderValue<string?>(reader["RecipientAddress"]);
						result.RecipientNote = GetDbReaderValue<string?>(reader["RecipientNote"]);
						result.OrderDate = GetDbReaderValue<DateTime?>(reader["OrderDate"]);
						result.ConfirmDate = GetDbReaderValue<DateTime?>(reader["ConfirmDate"]);
						result.DeliveryDate = GetDbReaderValue<DateTime?>(reader["DeliveryDate"]);
						result.CancelDate = GetDbReaderValue<DateTime?>(reader["CancelDate"]);
						result.ReasonCancel = GetDbReaderValue<string?>(reader["ReasonCancel"]);
						result.Status = GetDbReaderValue<int>(reader["ReasonCanStatuscle"]);
					}
				}
			}

            return result;
        }

		public int? Insert(SqlConnection connection, OrderInfo infoInsert)
		{
			string strSQl = @"
			INSERT INTO [dbo].[Order]
				   ([CustomerID]
				   ,[RecipientName]
				   ,[RecipientPhoneNumber]
				   ,[RecipientAddress]
				   ,[RecipientNote]
				   ,[OrderDate])
			OUTPUT INSERTED.OrderID
			VALUES
				   (@CustomerID
				   ,@RecipientName
				   ,@RecipientPhoneNumber
				   ,@RecipientAddress
				   ,@RecipientNote
				   ,GETDATE());";

            using (var command = new SqlCommand(strSQl, connection))
            {
                AddSqlParameter(command, "@CustomerID", infoInsert.CustomerID, System.Data.SqlDbType.Int);
                AddSqlParameter(command, "@RecipientName", infoInsert.RecipientName, System.Data.SqlDbType.NVarChar);
                AddSqlParameter(command, "@RecipientPhoneNumber", infoInsert.RecipientPhoneNumber, System.Data.SqlDbType.VarChar);
                AddSqlParameter(command, "@RecipientAddress", infoInsert.RecipientAddress, System.Data.SqlDbType.NVarChar);
                AddSqlParameter(command, "@RecipientNote", infoInsert.RecipientNote, System.Data.SqlDbType.NVarChar);

                WriteLogExecutingCommand(command);

				using (var reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						return GetDbReaderValue<int>(reader["OrderID"]);
					}
				}
			}

			return null;
		}

        public bool Update(SqlConnection connection, OrderInfo infoUpdate)
        {
            string strSql = @"
			UPDATE [dbo].[Order]
			   SET [CustomerID] = @CustomerID
				  ,[RecipientName] = @RecipientName
				  ,[RecipientPhoneNumber] = @RecipientPhoneNumber
				  ,[RecipientAddress] = @RecipientAddress
				  ,[RecipientNote] = @RecipientNote
				  ,[OrderDate] = @OrderDate
				  ,[ConfirmDate] = @ConfirmDate
				  ,[DeliveryDate] = @DeliveryDate
				  ,[CancelDate] = @CancelDate
				  ,[ReasonCancel] = @ReasonCancel
				  ,[Status] = @Status
			 WHERE OrderID = @OrderID";
			using (var command = new SqlCommand(strSql, connection))
			{
				AddSqlParameter(command, @"OrderID", infoUpdate.OrderID, System.Data.SqlDbType.Int);
				AddSqlParameter(command, @"CustomerID", infoUpdate.CustomerID, System.Data.SqlDbType.Int);
				AddSqlParameter(command, @"RecipientName", infoUpdate.RecipientName, System.Data.SqlDbType.NVarChar);
				AddSqlParameter(command, @"RecipientPhoneNumber", infoUpdate.RecipientPhoneNumber, System.Data.SqlDbType.VarChar);
				AddSqlParameter(command, @"RecipientAddress", infoUpdate.RecipientAddress, System.Data.SqlDbType.NVarChar);
				AddSqlParameter(command, @"RecipientNote", infoUpdate.RecipientNote, System.Data.SqlDbType.NVarChar);
				AddSqlParameter(command, @"OrderDate", infoUpdate.OrderDate, System.Data.SqlDbType.DateTime);
				AddSqlParameter(command, @"ConfirmDate", infoUpdate.ConfirmDate, System.Data.SqlDbType.DateTime);
				AddSqlParameter(command, @"DeliveryDate", infoUpdate.DeliveryDate, System.Data.SqlDbType.DateTime);
				AddSqlParameter(command, @"CancelDate", infoUpdate.CancelDate, System.Data.SqlDbType.DateTime);
				AddSqlParameter(command, @"ReasonCancel", infoUpdate.ReasonCancel, System.Data.SqlDbType.NVarChar);
				AddSqlParameter(command, @"Status", infoUpdate.Status, System.Data.SqlDbType.Int);

                WriteLogExecutingCommand(command);
                return command.ExecuteNonQuery() > 0;
            }

        }

        public bool Delete(SqlConnection connection, int OrderID)
        {
            string strSQL = @"
               DELETE FROM [Order] WHERE OrderID = @OrderID";
            using (var command = new SqlCommand(strSQL, connection))
            {
                AddSqlParameter(command, "@OrderID", OrderID, System.Data.SqlDbType.Int);
                WriteLogExecutingCommand(command);

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
