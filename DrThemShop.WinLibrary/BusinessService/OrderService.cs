using DrThemShop.WinLibrary.APICalling;
using DrThemShop.WinLibrary.Helper;
using System;
using System.Net;

namespace DrThemShop.WinLibrary.BusinessService
{
    public class OrderService : BaseService<OrderService>
    {
        private static string HOST_ADDRESS = BusinessObjectFactory<APIConnectionFactory>.GetBusinessObject().GetHostAddress();
        private static string URI_MANAGER = "/api/Order";
        private static string URL_SEND_REQ = HOST_ADDRESS + URI_MANAGER;

		public class OrderInfo
		{
			public int OrderID { get; set; }
			public int CustomerID { get; set; }
			public string CustomerName { get; set; }
			public string RecipientName { get; set; }
			public string RecipientPhoneNumber { get; set; }
			public string RecipientAddress { get; set; }
			public string RecipientNote { get; set; }
			public DateTime? OrderDate { get; set; }
			public DateTime? ConfirmDate { get; set; }
			public DateTime? DeliveryDate { get; set; }
			public DateTime? CancelDate { get; set; }
			public string ReasonCancel { get; set; }
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
            public string Search { get; set; }
        }

        public ListResponeMessage<OrderInfo> GetListOrder(OrderFilterInfo filter = null)
        {
            var sendUrl = URL_SEND_REQ;

			sendUrl += $"?dateFrom={filter.DateFrom.GetValueOrDefault().Date.ToString("yyyy-MM-dd")}&dateTo={filter.DateTo.GetValueOrDefault().Date.ToString("yyyy-MM-dd")}&status={filter.Status.GetValueOrDefault()}&filter={filter.Search}";

            return APICallingHelper.GetSingleResultFromAPI<string, ListResponeMessage<OrderInfo>>(null, sendUrl, WebRequestMethods.Http.Get);
        }

        public SingleResponeMessage<OrderInfo> GetOrder(int orderID)
        {
            var sendUrl = $"{URL_SEND_REQ}/{orderID}";

            return APICallingHelper.GetSingleResultFromAPI<string, SingleResponeMessage<OrderInfo>>(null, sendUrl, WebRequestMethods.Http.Get);
        }

        public SingleResponeMessage<OrderInfo> UpdateOrder(OrderInfo infoUpdate)
        {
            var sendUrl = $"{URL_SEND_REQ}/{infoUpdate.OrderID}";

            return APICallingHelper.GetSingleResultFromAPI<OrderInfo, SingleResponeMessage<OrderInfo>>(infoUpdate, sendUrl, WebRequestMethods.Http.Put);
        }

    }
}
