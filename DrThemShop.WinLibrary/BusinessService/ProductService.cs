using DrThemShop.WinLibrary.APICalling;
using DrThemShop.WinLibrary.Helper;
using System.Net;

namespace DrThemShop.WinLibrary.BusinessService
{
    public class ProductService : BaseService<ProductService>
    {
        private static string HOST_ADDRESS = BusinessObjectFactory<APIConnectionFactory>.GetBusinessObject().GetHostAddress();
        private static string URI_MANAGER = "/api/Product";
        private static string URL_SEND_REQ = HOST_ADDRESS + URI_MANAGER;

        public class ProductInfo
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public byte[] ProductImage { get; set; }
            public int Price { get; set; }
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
            public string Unit { get; set; }
            public string Content { get; set; }

            public void CopyValue(ProductInfo info)
            {
                this.ProductID = info.ProductID;
                this.ProductName = info.ProductName;
                this.ProductImage = info.ProductImage;
                this.Price = info.Price;
                this.CategoryID = info.CategoryID;
                this.CategoryName = info.CategoryName;
                this.Unit = info.Unit;
                this.Content = info.Content;
            }
        }

        public ListResponeMessage<ProductInfo> GetListProduct(string filter = null, int? categoryID = null)
        {
            var sendUrl = $"{URL_SEND_REQ}?filter={filter}&categoryID={categoryID}";

            return APICallingHelper.GetSingleResultFromAPI<string, ListResponeMessage<ProductInfo>>(null, sendUrl, WebRequestMethods.Http.Get);
        }

        public SingleResponeMessage<ProductInfo> GetProduct(int productID)
        {
            var sendUrl = $"{URL_SEND_REQ}/{productID}";

            return APICallingHelper.GetSingleResultFromAPI<string, SingleResponeMessage<ProductInfo>>(null, sendUrl, WebRequestMethods.Http.Get);
        }

        public SingleResponeMessage<ProductInfo> InsertProduct(ProductInfo infoInsert)
        {
            var sendUrl = URL_SEND_REQ;

            return APICallingHelper.GetSingleResultFromAPI<ProductInfo, SingleResponeMessage<ProductInfo>>(infoInsert, sendUrl, WebRequestMethods.Http.Post);
        }

        public SingleResponeMessage<ProductInfo> UpdateProduct(ProductInfo infoUpdate)
        {
            var sendUrl = $"{URL_SEND_REQ}/{infoUpdate.ProductID}";

            return APICallingHelper.GetSingleResultFromAPI<ProductInfo, SingleResponeMessage<ProductInfo>>(infoUpdate, sendUrl, WebRequestMethods.Http.Put);
        }

        public SingleResponeMessage<ProductInfo> DeleteProduct(int productID)
        {
            var sendUrl = $"{URL_SEND_REQ}/{productID}";

            return APICallingHelper.GetSingleResultFromAPI<string, SingleResponeMessage<ProductInfo>>(null, sendUrl, "DELETE");
        }
    }
}
