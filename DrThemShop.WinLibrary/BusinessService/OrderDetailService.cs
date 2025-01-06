using DrThemShop.WinLibrary.APICalling;
using DrThemShop.WinLibrary.Helper;
using System.Net;

namespace DrThemShop.WinLibrary.BusinessService
{
    public class OrderDetailService : BaseService<OrderDetailService>
    {
        private static string HOST_ADDRESS = BusinessObjectFactory<APIConnectionFactory>.GetBusinessObject().GetHostAddress();
        private static string URI_MANAGER = "/api/OrderDetail";
        private static string URL_SEND_REQ = HOST_ADDRESS + URI_MANAGER;

        public class OrderDetailInfo
        {
            public int OrderID { get; set; }
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public double Price { get; set; }
            public int Amount { get; set; }
        }

        public ListResponeMessage<OrderDetailInfo> GetListOrderDetail(int orderID)
        {
            var sendUrl = $"{URL_SEND_REQ}/{orderID}";

            return APICallingHelper.GetSingleResultFromAPI<string, ListResponeMessage<OrderDetailInfo>>(null, sendUrl, WebRequestMethods.Http.Get);
        }
    }
}
