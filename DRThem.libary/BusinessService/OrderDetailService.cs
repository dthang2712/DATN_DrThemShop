using DrThem.Libary.BusinessService.Common;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace DrThem.Libary.BusinessService
{
	public class OrderDetailService : BaseService<OrderDetailService>
	{
		[DataContract]
		public class OrderDetailInfo
		{
			[DataMember]
			public int OrderDetailID { get; set; }

			[DataMember]
			public int OrderID { get; set; }

			[DataMember]
			public int ProductID { get; set; }

			[DataMember]
			public string? ProductName { get; set; }

			[DataMember]
			public byte[]? ProductImage { get; set; }

			[DataMember]
			public string? ProductImageBase64 { get; set; }

			[DataMember]
			public int Price { get; set; }

			[DataMember]
			public int Amount { get; set; }

			[DataMember]
			public string? Unit { get; set; }

			public void CopyValue(OrderDetailInfo info)
			{
				this.OrderDetailID = info.OrderDetailID;
				this.OrderID = info.OrderID;
				this.ProductID = info.ProductID;
				this.ProductName = info.ProductName;
				this.Price = info.Price;
				this.Amount = info.Amount;

			}
		}

		public List<OrderDetailInfo> GetListOrderDetail(SqlConnection connection, int orderID)
		{
			var result = new List<OrderDetailInfo>();
			string strSQL = @"
            SELECT O.[OrderDetailID]
                  ,O.[OrderID]
                  ,O.[ProductID]
                  ,P.[ProductName]
                  ,P.[ProductImage]
                  ,P.[Unit]
                  ,P.[Price]
                  ,O.[Amount]
              FROM [dbo].[OrderDetail] O
            LEFT JOIN Product P on O.ProductID = P.ProductID WHERE O.OrderID = @OrderID ";

			using (var command = new SqlCommand(strSQL, connection))
			{
				AddSqlParameter(command, "@OrderID", orderID, System.Data.SqlDbType.Int);
				WriteLogExecutingCommand(command);

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var item = new OrderDetailInfo();
						item.OrderDetailID = GetDbReaderValue<int>(reader["OrderDetailID"]);
						item.OrderID = GetDbReaderValue<int>(reader["OrderID"]);
						item.ProductID = GetDbReaderValue<int>(reader["ProductID"]);
						item.ProductName = GetDbReaderValue<string?>(reader["ProductName"]);
						item.ProductImage = GetDbReaderValue<byte[]?>(reader["ProductImage"]);
						item.Unit = GetDbReaderValue<string?>(reader["Unit"]);
						item.Price = GetDbReaderValue<int>(reader["Price"]);
						item.Amount = GetDbReaderValue<int>(reader["Amount"]);

						if (item.ProductImage != null)
						{
							item.ProductImageBase64 = Convert.ToBase64String(item.ProductImage);
						}

						result.Add(item);
					}
				}
			}

			return result;
		}

		public bool Insert(SqlConnection connection, OrderDetailInfo infoInsert)
		{
			string strSQl = @"
            INSERT INTO [dbo].[OrderDetail]
				   ([OrderID]
				   ,[ProductID]
				   ,[Amount])
			 VALUES
				   (@OrderID
				   ,@ProductID
				   ,@Amount)";


			using (var command = new SqlCommand(strSQl, connection))
			{
				AddSqlParameter(command, "@OrderID", infoInsert.OrderID, System.Data.SqlDbType.Int);
				AddSqlParameter(command, "@ProductID", infoInsert.ProductID, System.Data.SqlDbType.Int);
				AddSqlParameter(command, "@Amount", infoInsert.Amount, System.Data.SqlDbType.Int);

				WriteLogExecutingCommand(command);

				return command.ExecuteNonQuery() > 0;
			}
		}
		public bool Update(SqlConnection connection, OrderDetailInfo infoUpdate)
		{
			string strSql = @"
			UPDATE [dbo].[OrderDetail]
			   SET [OrderID] = @OrderID
				  ,[ProductID] = @ProductID
				  ,[Amount] = @Amount
			 WHERE OrderDetailID = @OrderDetailID";
			using (var command = new SqlCommand(strSql, connection))
			{
				AddSqlParameter(command, @"OrderDetailID", infoUpdate.OrderDetailID, System.Data.SqlDbType.Int);
				AddSqlParameter(command, @"OrderID", infoUpdate.OrderID, System.Data.SqlDbType.Int);
				AddSqlParameter(command, @"ProductID", infoUpdate.ProductID, System.Data.SqlDbType.Int);
				AddSqlParameter(command, @"Amount", infoUpdate.Amount, System.Data.SqlDbType.Int);
				WriteLogExecutingCommand(command);
				return command.ExecuteNonQuery() > 0;
			}
		}

		public bool Delete(SqlConnection connection, int orderDetailID)
		{
			string strSQL = @"DELETE FROM [OrderDetail] WHERE OrderDetailID = @OrderDetailID";
			using (var command = new SqlCommand(strSQL, connection))
			{
				AddSqlParameter(command, @"OrderDetailID", orderDetailID, System.Data.SqlDbType.Int);
				WriteLogExecutingCommand(command);

				return command.ExecuteNonQuery() > 0;
			}
		}
	}
}
