using System.Globalization;
using System.Reflection;
using System.Text;


namespace DrThem.Libary.Helper
{
    public static class CommonCoreUtils
    {
        /// <summary>
        /// 	Logger
        /// </summary>
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// //Thiết lập định dạng thời gian và dấu chấm động
        /// </summary>
        public static void SetFormatSystem()
        {
            var dateTimeInfo = new DateTimeFormatInfo();
            dateTimeInfo.DateSeparator = "-";
            dateTimeInfo.LongDatePattern = "yyyy-MM-dd";
            dateTimeInfo.ShortDatePattern = "yy-MM-dd";
            dateTimeInfo.LongTimePattern = "hh:mm:ss";
            dateTimeInfo.ShortTimePattern = "hh:mm";

            var ci = new CultureInfo("en-us");
            ci.DateTimeFormat = dateTimeInfo;
            ci.NumberFormat.NumberGroupSeparator = ",";//Dấu phẩy phân cách hàng nghìn
            ci.NumberFormat.NumberDecimalSeparator = ".";//Dấu chấm phân cách phần thập phân

            CultureInfo.DefaultThreadCurrentCulture = ci;
            CultureInfo.DefaultThreadCurrentUICulture = ci;

            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            //***********************************************************
        }

        /// <summary>
        /// Hàm cắt đi dấu nháy trong chuổi
        /// </summary>
        /// <param name="Str">Chuổi ký tự truyền vào</param>
        /// <returns>Chuổi ký tự trả về</returns>
        public static string ConvertString(string strValue)
        {
            if (!string.IsNullOrEmpty(strValue))
            {
                string strConvert = strValue.Replace("'", "''");
                return strConvert;
            }

            return strValue;
        }
    }
}
