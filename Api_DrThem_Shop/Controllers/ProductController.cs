using DrThem.Libary.APICalling;
using DrThem.Libary.BusinessService;
using DrThem.Libary.BusinessService.Common;
using log4net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Api_DrThem_Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ProductController : Controller
    {
        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [HttpGet]
        public IActionResult SearchProduct([FromQuery] string? filter, int? categoryID)
        {
            try
            {
                using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
                {
                    List<ProductService.ProductInfo> listProductInfo = ProductService.GetInstance().GetListProduct(connection, filter, categoryID);

					return Ok(new ListResponseMessage<ProductService.ProductInfo>
					{
						IsSuccess = true,
						TotalRecords = listProductInfo.Count,
						Data = listProductInfo
					});
				}

			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new ListResponseMessage<CategoryService.CategoryInfo>
				{
					IsSuccess = false,
					TotalRecords = 0,
					Data = null,
					Err = new ErrorMessage
					{
						MsgCode = "001",
						MsgString = ex.Message.ToString()
					}
				});
			}

        }

        [HttpGet("{productID}")]
        public IActionResult SearchProduct(int productID)
        {
            try
            {
                using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
                {
                    ProductService.ProductInfo productInfo = ProductService.GetInstance().GetProduct(connection, productID);

					return Ok(new SingleResponseMessage<ProductService.ProductInfo>
					{
						IsSuccess = true,
						Item = productInfo
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<ProductService.ProductInfo>
				{
					IsSuccess = false,
					Item = null,
					Err = new ErrorMessage
					{
						MsgCode = "001",
						MsgString = ex.Message.ToString()
					}
				});
			}
		}

        [HttpPost]
        public IActionResult InsertProduct(ProductService.ProductInfo infoInsert)
        {
            try
            {
                using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
                {
                    bool result = ProductService.GetInstance().Insert(connection, infoInsert);

					return Ok(new SingleResponseMessage<ProductService.ProductInfo>
					{
						IsSuccess = result,
						Item = infoInsert
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<ProductService.ProductInfo>(ex.Message.ToString()));
			}
		}

        [HttpPut("{productID}")]
        public IActionResult UpdateProduct(ProductService.ProductInfo infoUpdate)
        {
            try
            {
                using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
                {
                    bool result = ProductService.GetInstance().Update(connection, infoUpdate);

					return Ok(new SingleResponseMessage<ProductService.ProductInfo>
					{
						IsSuccess = result,
						Item = infoUpdate
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<ProductService.ProductInfo>(ex.Message.ToString()));
			}
		}

        [HttpDelete("{productID}")]
        public IActionResult DeleteProduct(int productID)
        {
            try
            {
                using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
                {
                    bool result = ProductService.GetInstance().Delete(connection, productID);

					return Ok(new SingleResponseMessage<ProductService.ProductInfo>
					{
						IsSuccess = result
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<ProductService.ProductInfo>(ex.Message.ToString()));
			}
		}
	}
}
