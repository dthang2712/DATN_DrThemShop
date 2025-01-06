using DrThem.Libary.BusinessService.Common;
using DrThem.Libary.BusinessService;
using log4net;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using DrThem.Libary.APICalling;

namespace Api_DrThem_Shop.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[AllowAnonymous]
	public class CategoryController : Controller
	{
		private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		[HttpGet]
		public IActionResult SearchCategory([FromQuery] string? filter)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					List<CategoryService.CategoryInfo> listCategoryInfo = CategoryService.GetInstance().GetListCategory(connection, filter);

					return Ok(new ListResponseMessage<CategoryService.CategoryInfo>
					{
						IsSuccess = true,
						TotalRecords = listCategoryInfo.Count,
						Data = listCategoryInfo
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

		[HttpGet("{categoryID}")]
		public IActionResult SearchCategory(int categoryID)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					CategoryService.CategoryInfo categoryInfo = CategoryService.GetInstance().GetCategory(connection, categoryID);

					return Ok(new SingleResponseMessage<CategoryService.CategoryInfo>
					{
						IsSuccess = true,
						Item = categoryInfo
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<CategoryService.CategoryInfo>
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
		public IActionResult InsertCategory(CategoryService.CategoryInfo infoInsert)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					bool result = CategoryService.GetInstance().Insert(connection, infoInsert);

					return Ok(new SingleResponseMessage<CategoryService.CategoryInfo>
					{
						IsSuccess = result,
						Item = infoInsert
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<CategoryService.CategoryInfo>(ex.Message.ToString()));
			}
		}

		[HttpPut("{categoryID}")]
		public IActionResult UpdateCategory(CategoryService.CategoryInfo infoUpdate)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					bool result = CategoryService.GetInstance().Update(connection, infoUpdate);

					return Ok(new SingleResponseMessage<CategoryService.CategoryInfo>
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

		[HttpDelete("{categoryID}")]
		public IActionResult DeleteCategory(int categoryID)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					bool result = CategoryService.GetInstance().Delete(connection, categoryID);

					return Ok(new SingleResponseMessage<CategoryService.CategoryInfo>
					{
						IsSuccess = result
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
