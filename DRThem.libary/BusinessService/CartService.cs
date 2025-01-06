using DrThem.Libary.BusinessService.Common;
using System.Data.SqlClient;

namespace DrThem.Libary.BusinessService
{
	public class CartService : BaseService<CartService>
	{
		public class CartInfo
		{
			public int CartID { get; set; }
			public int CustomerID { get; set; }
			public int ProductID { get; set; }
			public string? ProductName { get; set; }
			public byte[]? ProductImage { get; set; }
			public string? ProductImageBase64 { get; set; }
			public int Price { get; set; }
			public int Amount { get; set; }
			public string? Unit { get; set; }

			public void CopyValue(CartInfo info)
			{
				this.CartID = info.CartID;
				this.CustomerID = info.CustomerID;
				this.ProductID = info.ProductID;
				this.ProductName = info.ProductName;
				this.Price = info.Price;
				this.Amount = info.Amount;
			}
		}

		public List<CartInfo> GetListCartCustomer(SqlConnection connection, int customerID)
		{
			var result = new List<CartInfo>();
			string strSQL = @"
            SELECT C.CartID,
                C.[CustomerID]
                ,C.[ProductID]
                ,P.ProductName
                ,P.ProductImage
                ,P.Price
                ,P.Unit
                ,C.[Amount]
                FROM [Cart] AS C 
                LEFT JOIN Product AS P ON C.ProductID = P.ProductID
                WHERE C.CustomerID = @CustomerID ";
			using (var command = new SqlCommand(strSQL, connection))
			{
				AddSqlParameter(command, "@CustomerID", customerID, System.Data.SqlDbType.Int);

				WriteLogExecutingCommand(command);

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var item = new CartInfo();
						item.CartID = GetDbReaderValue<int>(reader["CartID"]);
						item.CustomerID = GetDbReaderValue<int>(reader["CustomerID"]);
						item.ProductID = GetDbReaderValue<int>(reader["ProductID"]);
						item.ProductName = GetDbReaderValue<string?>(reader["ProductName"]);
						item.Price = GetDbReaderValue<int>(reader["Price"]);
						item.Amount = GetDbReaderValue<int>(reader["Amount"]);
						item.ProductImage = GetDbReaderValue<byte[]?>(reader["ProductImage"]);
						item.Unit = GetDbReaderValue<string?>(reader["Unit"]);

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

		public bool SaveCartInfo(SqlConnection connection, CartInfo infoInsert)
		{
			string strSQL = @"
            IF EXISTS (SELECT * FROM [Cart] WHERE [CustomerID] = @CustomerID and [ProductID] = @ProductID)
            BEGIN
                UPDATE [Cart]
                SET [Amount] = [Amount] + @Amount
                WHERE [CustomerID] = @CustomerID and [ProductID] = @ProductID;
            END
            ELSE
            BEGIN
                INSERT INTO [Cart]
                            ([CustomerID]
                            ,[ProductID]
                            ,[Amount])
                
                        VALUES
                            (@CustomerID
                            ,@ProductID
                            ,@Amount);
            END";

			using (var command = new SqlCommand(strSQL, connection))
			{
				AddSqlParameter(command, "@CustomerID", infoInsert.CustomerID, System.Data.SqlDbType.Int);
				AddSqlParameter(command, "@ProductID", infoInsert.ProductID, System.Data.SqlDbType.Int);
				AddSqlParameter(command, "@Amount", infoInsert.Amount, System.Data.SqlDbType.Int);


				WriteLogExecutingCommand(command);

				return command.ExecuteNonQuery() > 0;
			}
		}

		public bool DeleteCart(SqlConnection connection, int cartID)
		{
			using (var command = new SqlCommand("DELETE FROM [Cart] WHERE CartID = @CartID", connection))
			{
				AddSqlParameter(command, "@CartID", cartID, System.Data.SqlDbType.Int);
				WriteLogExecutingCommand(command);

				return command.ExecuteNonQuery() > 0;
			}
		}

		public bool UpdateAmountCart(SqlConnection connection, CartInfo infoUpdate)
		{
			using (var command = new SqlCommand("UPDATE [Cart] SET [Amount] = @Amount WHERE [CartID] = @CartID", connection))
			{
				AddSqlParameter(command, "@CartID", infoUpdate.CartID, System.Data.SqlDbType.Int);
				AddSqlParameter(command, "@Amount", infoUpdate.Amount, System.Data.SqlDbType.Int);
				WriteLogExecutingCommand(command);
				return command.ExecuteNonQuery() > 0;
			}
		}

	}
}
