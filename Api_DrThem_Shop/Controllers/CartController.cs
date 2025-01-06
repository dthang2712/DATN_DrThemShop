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
	public class CartController : Controller
	{
		private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		[HttpGet("{customerID}")]
		public IActionResult GetListCart(int customerID)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					List<CartService.CartInfo> listCartInfo = CartService.GetInstance().GetListCartCustomer(connection, customerID);

					return Ok(new ListResponseMessage<CartService.CartInfo>
					{
						IsSuccess = true,
						TotalRecords = listCartInfo.Count,
						Data = listCartInfo
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new ListResponseMessage<CartService.CartInfo>
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

		[HttpPost]
		public IActionResult InsertCart(CartService.CartInfo infoInsert)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					bool result = CartService.GetInstance().SaveCartInfo(connection, infoInsert);

					return Ok(new SingleResponseMessage<CartService.CartInfo>
					{
						IsSuccess = result,
						Item = infoInsert
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<CartService.CartInfo>(ex.Message.ToString()));
			}
		}

		[HttpDelete("{cartID}")]
		public IActionResult DeleteCart(int cartID)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					bool result = CartService.GetInstance().DeleteCart(connection, cartID);

					return Ok(new SingleResponseMessage<CartService.CartInfo>
					{
						IsSuccess = result
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<CartService.CartInfo>(ex.Message.ToString()));
			}
		}

		[HttpPut("{cartID}")]
		public IActionResult UpdateAmountCart(CartService.CartInfo infoUpdate)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					bool result = CartService.GetInstance().UpdateAmountCart(connection, infoUpdate);

					return Ok(new SingleResponseMessage<CartService.CartInfo>
					{
						IsSuccess = result,
						Item = infoUpdate
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<CategoryService.CategoryInfo>(ex.Message.ToString()));
			}
		}
	}
}
