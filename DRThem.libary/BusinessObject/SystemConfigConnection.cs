using System.Data.SqlClient;

namespace DrThem.Libary.BusinessObject
{
    public static class SystemConfigConnection
    {
        public delegate SqlConnection GetConnectionProto();
        public static GetConnectionProto GetConnection;
    }
}
