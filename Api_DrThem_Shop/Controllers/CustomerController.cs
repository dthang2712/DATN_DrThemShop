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
	public class CustomerController : Controller
	{
		private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		[HttpGet("{phoneNumber}")]
		public IActionResult GetCustomer(string phoneNumber)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					CustomerService.CustomerInfo customerInfo = CustomerService.GetInstance().GetCustomer(connection, phoneNumber);
					return Ok(new SingleResponseMessage<CustomerService.CustomerInfo>
					{
						IsSuccess = true,
						Item = customerInfo
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<CustomerService.CustomerInfo>
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
		public IActionResult InserCustomer(CustomerService.CustomerInfo infoInsert)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					bool result = CustomerService.GetInstance().Insert(connection, infoInsert);

					return Ok(new SingleResponseMessage<CustomerService.CustomerInfo>
					{
						IsSuccess = result,
						Item = infoInsert
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<CustomerService.CustomerInfo>(ex.Message.ToString()));
			}
		}

		[HttpGet("IsExistPhoneNumber/{phoneNumber}")]
		public IActionResult CheckInsertPhoneNumber(string phoneNumber)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					bool result = CustomerService.GetInstance().IsExistPhoneNumber(connection, phoneNumber);

					return Ok(new SingleResponseMessage<string>
					{
						IsSuccess = result,
						Item = phoneNumber
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<string>
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

		[HttpPut("{customerID}")]
		public IActionResult UpdateCustomer(CustomerService.CustomerInfo infoUpdate)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					bool result = CustomerService.GetInstance().Update(connection, infoUpdate);

					return Ok(new SingleResponseMessage<CustomerService.CustomerInfo>
					{
						IsSuccess = result,
						Item = infoUpdate
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<CustomerService.CustomerInfo>(ex.Message.ToString()));
			}
		}
	}
}
