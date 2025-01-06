using DrThem.Libary.BusinessService.Common;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace DrThem.Libary.BusinessService
{
    public class ProductService : BaseService<ProductService>
    {
        [DataContract]
        public class ProductInfo
        {
            [DataMember]
            public int ProductID { get; set; }

            [DataMember]
            public string ProductName { get; set; }

			[DataMember]
			public byte[]? ProductImage { get; set; }
			[DataMember]
			public string? ProductImageBase64 { get; set; }

            [DataMember]
            public int Price { get; set; }

            [DataMember]
            public int CategoryID { get; set; }

            [DataMember]
            public string? CategoryName { get; set; }

            [DataMember]
            public string Unit { get; set; }

            [DataMember]
            public string? Content { get; set; }

            public void CopyValue(ProductInfo info)
            {
                this.ProductID = info.ProductID;
                this.ProductName = info.ProductName;
                this.ProductImage = info.ProductImage;
                this.Price = info.Price;
                this.CategoryID = info.CategoryID;
                this.Unit = info.Unit;
                this.Content = info.Content;
            }
        }

        public List<ProductInfo> GetListProduct(SqlConnection connection, string? strSearch = null, int? categoryID = null)
        {
            var result = new List<ProductInfo>();
            string strSQL = @"
            SELECT P.[ProductID]
                  ,P.[ProductName]
                  ,P.[ProductImage]
                  ,P.[Price]
                  ,P.[CategoryID]
                  ,C.[CategoryName]
                  ,P.[Unit]
                  ,P.[Content]
              FROM [dbo].[Product] P 
            LEFT JOIN Category C ON P.CategoryID = C.CategoryID WHERE 1=1 ";
            using (var command = new SqlCommand(strSQL, connection))
            {
                if (!string.IsNullOrEmpty(strSearch))
                {
                    command.CommandText += "and (P.ProductID like @strSearch or P.ProductName like @strSearch) ";
                    AddSqlParameter(command, "@strSearch", "%" + strSearch + "%", System.Data.SqlDbType.NVarChar);
                }

                if (categoryID.HasValue)
                {
                    command.CommandText += "and P.CategoryID = @CategoryID ";
                    AddSqlParameter(command, "@CategoryID", categoryID, System.Data.SqlDbType.Int);
                }

                WriteLogExecutingCommand(command);

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var item = new ProductInfo();
						item.ProductID = GetDbReaderValue<int>(reader["ProductID"]);
						item.ProductName = GetDbReaderValue<string>(reader["ProductName"]);
						item.ProductImage = GetDbReaderValue<byte[]?>(reader["ProductImage"]);
						item.Price = GetDbReaderValue<int>(reader["Price"]);
						item.CategoryID = GetDbReaderValue<int>(reader["CategoryID"]);
						item.CategoryName = GetDbReaderValue<string?>(reader["CategoryName"]);
						item.Unit = GetDbReaderValue<string>(reader["Unit"]);
						item.Content = GetDbReaderValue<string?>(reader["Content"]);

						if (item.ProductImage?.Length > 0)
						{
							item.ProductImageBase64 = Convert.ToBase64String(item.ProductImage);
						}

						result.Add(item);
					}
				}
			}
			return result;
		}

        public ProductInfo GetProduct(SqlConnection connection, int productID)
        {
            ProductInfo result = null;
            string strSQL = @"
            SELECT P.[ProductID]
                  ,P.[ProductName]
                  ,P.[ProductImage]
                  ,P.[Price]
                  ,P.[CategoryID]
                  ,C.[CategoryName]
                  ,P.[Unit]
                  ,P.[Content]
              FROM [dbo].[Product] P 
            LEFT JOIN Category C ON P.CategoryID = C.CategoryID WHERE P.ProductID = @ProductID ";
            using (var command = new SqlCommand(strSQL, connection))
            {
                AddSqlParameter(command, "@ProductID", productID, System.Data.SqlDbType.Int);

                WriteLogExecutingCommand(command);

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						result = new ProductInfo();
						result.ProductID = GetDbReaderValue<int>(reader["ProductID"]);
						result.ProductName = GetDbReaderValue<string>(reader["ProductName"]);
						result.ProductImage = GetDbReaderValue<byte[]?>(reader["ProductImage"]);
						result.Price = GetDbReaderValue<int>(reader["Price"]);
						result.CategoryID = GetDbReaderValue<int>(reader["CategoryID"]);
						result.CategoryName = GetDbReaderValue<string?>(reader["CategoryName"]);
						result.Unit = GetDbReaderValue<string>(reader["Unit"]);
						result.Content = GetDbReaderValue<string?>(reader["Content"]);

						if (result.ProductImage?.Length > 0)
						{
							result.ProductImageBase64 = Convert.ToBase64String(result.ProductImage);
						}
					}
				}
			}
			return result;
		}

        public bool Insert(SqlConnection connection, ProductInfo infoInsert)
        {
            string strSQL = @"
            INSERT INTO [dbo].[Product]
                   ([ProductName]
                   ,[ProductImage]
                   ,[Price]
                   ,[CategoryID]
                   ,[Unit]
                   ,[Content])
             VALUES
                   (@ProductName
                   ,@ProductImage
                   ,@Price
                   ,@CategoryID
                   ,@Unit
                   ,@Content)";
            using (var command = new SqlCommand(strSQL, connection))
            {
                AddSqlParameter(command, "@ProductName", infoInsert.ProductName, System.Data.SqlDbType.NVarChar);
                AddSqlParameter(command, "@ProductImage", infoInsert.ProductImage, System.Data.SqlDbType.Image);
                AddSqlParameter(command, "@Price", infoInsert.Price, System.Data.SqlDbType.Int);
                AddSqlParameter(command, "@CategoryID", infoInsert.CategoryID, System.Data.SqlDbType.Int);
                AddSqlParameter(command, "@Unit", infoInsert.Unit, System.Data.SqlDbType.NVarChar);
                AddSqlParameter(command, "@Content", infoInsert.Content, System.Data.SqlDbType.NVarChar);

                WriteLogExecutingCommand(command);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(SqlConnection connection, ProductInfo infoUpdate)
        {
            string strSQL = @"
            UPDATE [dbo].[Product]
			   SET [ProductName] = @ProductName
				  ,[ProductImage] = @ProductImage
				  ,[Price] = @Price
				  ,[CategoryID] = @CategoryID
				  ,[Unit] = @Unit
				  ,[Content] = @Content
            WHERE [ProductID] = @ProductID";

            using (var command = new SqlCommand(strSQL, connection))
            {
                AddSqlParameter(command, "@ProductID", infoUpdate.ProductID, System.Data.SqlDbType.Int);
                AddSqlParameter(command, "@ProductName", infoUpdate.ProductName, System.Data.SqlDbType.NVarChar);
                AddSqlParameter(command, "@ProductImage", infoUpdate.ProductImage, System.Data.SqlDbType.Image);
                AddSqlParameter(command, "@Price", infoUpdate.Price, System.Data.SqlDbType.Int);
                AddSqlParameter(command, "@CategoryID", infoUpdate.CategoryID, System.Data.SqlDbType.Int);
                AddSqlParameter(command, "@Unit", infoUpdate.Unit, System.Data.SqlDbType.NVarChar);
                AddSqlParameter(command, "@Content", infoUpdate.Content, System.Data.SqlDbType.NVarChar);

                WriteLogExecutingCommand(command);
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(SqlConnection connection, int ProductID)
        {
            string strSQL = @"DELETE FROM [Product] WHERE ProductID = @ProductID ";
            using (var command = new SqlCommand(strSQL, connection))
            {
                AddSqlParameter(command, "@ProductID", ProductID, System.Data.SqlDbType.Int);
                WriteLogExecutingCommand(command);

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
