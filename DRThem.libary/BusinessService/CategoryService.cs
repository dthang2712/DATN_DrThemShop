using DrThem.Libary.BusinessService.Common;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace DrThem.Libary.BusinessService
{
    public class CategoryService : BaseService<CategoryService>
    {
        [DataContract]
        public class CategoryInfo
        {
            [DataMember]
            public int CategoryID { get; set; }

            [DataMember]
            public string CategoryName { get; set; }

            [DataMember]
            public string? Description { get; set; }

            [DataMember]
            public byte[]? Image { get; set; }

			[DataMember]
			public string? ImageBase64 { get; set; }

			public void CopyValue(CategoryInfo info)
			{
				this.CategoryID = info.CategoryID;
				this.CategoryName = info.CategoryName;
				this.Description = info.Description;
				this.Image = info.Image;
				this.ImageBase64 = info.ImageBase64;
			}
		}
		public List<CategoryInfo> GetListCategory(SqlConnection connection, string strSearch = null)
		{
			var result = new List<CategoryInfo>();
			string strSQL = @"
            SELECT [CategoryID]
                  ,[CategoryName]
                  ,[Description]
                  ,[Image]
              FROM [dbo].[Category] WHERE 1=1 ";

            using (var command = new SqlCommand(strSQL, connection))
            {
                if (!string.IsNullOrEmpty(strSearch))
                {
                    command.CommandText += "and CategoryID like @strSearch or CategoryName like @strSearch";
                    AddSqlParameter(command, "@strSearch", "%" + strSearch + "%", System.Data.SqlDbType.NVarChar);
                }

                WriteLogExecutingCommand(command);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new CategoryInfo();
                        item.CategoryID = GetDbReaderValue<int>(reader["CategoryID"]);
                        item.CategoryName = GetDbReaderValue<string>(reader["CategoryName"]);
                        item.Description = GetDbReaderValue<string?>(reader["Description"]);
                        item.Image = GetDbReaderValue<byte[]?>(reader["Image"]);

						if (item.Image?.Length > 0)
						{
							item.ImageBase64 = Convert.ToBase64String(item.Image);
						}

						result.Add(item);
					}
				}
			}

            return result;
        }

        public CategoryInfo GetCategory(SqlConnection connection, int categoryID)
        {
            CategoryInfo result = null;
            string strSQL = @"
            SELECT [CategoryID]
                  ,[CategoryName]
                  ,[Description]
                  ,[Image]
              FROM [dbo].[Category] WHERE CategoryID = @CategoryID ";

            using (var command = new SqlCommand(strSQL, connection))
            {
                AddSqlParameter(command, "@CategoryID", categoryID, System.Data.SqlDbType.Int);

                WriteLogExecutingCommand(command);

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						result = new CategoryInfo();
						result.CategoryID = GetDbReaderValue<int>(reader["CategoryID"]);
						result.CategoryName = GetDbReaderValue<string>(reader["CategoryName"]);
						result.Description = GetDbReaderValue<string?>(reader["Description"]);
						result.Image = GetDbReaderValue<byte[]?>(reader["Image"]);

						if (result.Image?.Length > 0)
						{
							result.ImageBase64 = Convert.ToBase64String(result.Image);
						}
					}
				}
			}

            return result;
        }

        public bool Insert(SqlConnection connection, CategoryInfo infoInsert)
        {
            string strSQl = @"
            INSERT INTO [dbo].[Category]
                   ([CategoryName]
                   ,[Description]
                   ,[Image])
             VALUES
                   (@CategoryName
                   ,@Description
                   ,@Image)";

            using (var command = new SqlCommand(strSQl, connection))
            {
                AddSqlParameter(command, "@CategoryName", infoInsert.CategoryName, System.Data.SqlDbType.NVarChar);
                AddSqlParameter(command, "@Description", infoInsert.Description, System.Data.SqlDbType.NVarChar);
                AddSqlParameter(command, "@Image", infoInsert.Image, System.Data.SqlDbType.Image);

                WriteLogExecutingCommand(command);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(SqlConnection connection, CategoryInfo infoUpdate)
        {
            string strSql = @"
               UPDATE [dbo].[Category]
               SET [CategoryName] = @CategoryName
                  ,[Description] = @Description
                  ,[Image] = @Image
             WHERE CategoryID = @CategoryID";
            using (var command = new SqlCommand(strSql, connection))
            {
                AddSqlParameter(command, @"CategoryID", infoUpdate.CategoryID, System.Data.SqlDbType.Int);
                AddSqlParameter(command, "@CategoryName", infoUpdate.CategoryName, System.Data.SqlDbType.NVarChar);
                AddSqlParameter(command, "@Description", infoUpdate.Description, System.Data.SqlDbType.NVarChar);
                AddSqlParameter(command, "@Image", infoUpdate.Image, System.Data.SqlDbType.Image);
                WriteLogExecutingCommand(command);
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(SqlConnection connection, int CategoryID)
        {
            string strSQL = @"DELETE FROM [Category] WHERE CategoryID = @CategoryID";
            using (var command = new SqlCommand(strSQL, connection))
            {
                AddSqlParameter(command, "@CategoryID", CategoryID, System.Data.SqlDbType.Int);
                WriteLogExecutingCommand(command);

                return command.ExecuteNonQuery() > 0;
            }
        }


    }
}
