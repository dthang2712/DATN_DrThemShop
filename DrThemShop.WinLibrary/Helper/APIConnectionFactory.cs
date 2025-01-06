using log4net;
using System.Reflection;

namespace DrThemShop.WinLibrary.Helper
{
    public class APIConnectionFactory
    {
        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public string HostAddress { get; set; }

        public string GetHostAddress()
        {
            return HostAddress;
        }
    }
}
