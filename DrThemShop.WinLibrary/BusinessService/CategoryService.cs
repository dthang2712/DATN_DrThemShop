using DrThemShop.WinLibrary.APICalling;
using DrThemShop.WinLibrary.Helper;
using System.Net;

namespace DrThemShop.WinLibrary.BusinessService
{
    public class CategoryService : BaseService<CategoryService>
    {
        private static string HOST_ADDRESS = BusinessObjectFactory<APIConnectionFactory>.GetBusinessObject().GetHostAddress();
        private static string URI_MANAGER = "/api/Category";
        private static string URL_SEND_REQ = HOST_ADDRESS + URI_MANAGER;

        public class CategoryInfo
        {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
            public string Description { get; set; }
            public byte[] Image { get; set; }

            public void CopyValue(CategoryInfo info)
            {
                this.CategoryID = info.CategoryID;
                this.CategoryName = info.CategoryName;
                this.Description = info.Description;
                this.Image = info.Image;
            }
        }

        public ListResponeMessage<CategoryInfo> GetListCategory(string filter = null)
        {
            var sendUrl = URL_SEND_REQ;
            if (!string.IsNullOrEmpty(filter))
            {
                sendUrl += "?filter=" + filter;
            }

            return APICallingHelper.GetSingleResultFromAPI<string, ListResponeMessage<CategoryInfo>>(null, sendUrl, WebRequestMethods.Http.Get);
        }

        public SingleResponeMessage<CategoryInfo> GetCategory(int categoryID)
        {
            var sendUrl = $"{URL_SEND_REQ}/{categoryID}";

            return APICallingHelper.GetSingleResultFromAPI<string, SingleResponeMessage<CategoryInfo>>(null, sendUrl, WebRequestMethods.Http.Get);
        }

        public SingleResponeMessage<CategoryInfo> InsertCategory(CategoryInfo infoInsert)
        {
            var sendUrl = URL_SEND_REQ;

            return APICallingHelper.GetSingleResultFromAPI<CategoryInfo, SingleResponeMessage<CategoryInfo>>(infoInsert, sendUrl, WebRequestMethods.Http.Post);
        }

        public SingleResponeMessage<CategoryInfo> UpdateCategory(CategoryInfo infoUpdate)
        {
            var sendUrl = $"{URL_SEND_REQ}/{infoUpdate.CategoryID}";

            return APICallingHelper.GetSingleResultFromAPI<CategoryInfo, SingleResponeMessage<CategoryInfo>>(infoUpdate, sendUrl, WebRequestMethods.Http.Put);
        }

        public SingleResponeMessage<CategoryInfo> DeleteCategory(int categoryID)
        {
            var sendUrl = $"{URL_SEND_REQ}/{categoryID}";

            return APICallingHelper.GetSingleResultFromAPI<string, SingleResponeMessage<CategoryInfo>>(null, sendUrl, "DELETE");
        }
    }
}
