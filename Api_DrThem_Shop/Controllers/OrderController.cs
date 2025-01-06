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
    public class OrderController : Controller
    {
        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [HttpGet]
        public IActionResult SearchOrder([FromQuery] DateTime? dateFrom, DateTime? dateTo, int? customerID, int? status, string? filter)
        {
            try
            {
                using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
                {
                    List<OrderService.OrderInfo> listOrderInfo = OrderService.GetInstance().GetListOrder(connection, new OrderService.OrderFilterInfo
                    {
                        DateFrom = dateFrom,
                        DateTo = dateTo,
                        CustomerID = customerID,
                        Status = status,
                        Search = filter
                    });

					return Ok(new ListResponseMessage<OrderService.OrderInfo>
					{
						IsSuccess = true,
						TotalRecords = listOrderInfo.Count,
						Data = listOrderInfo
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new ListResponseMessage<OrderService.OrderInfo>
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

        [HttpGet("{orderID}")]
        public IActionResult SearchOrder(int orderID)
        {
            try
            {
                using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
                {
                    OrderService.OrderInfo orderInfo = OrderService.GetInstance().GetOrder(connection, orderID);

					return Ok(new SingleResponseMessage<OrderService.OrderInfo>
					{
						IsSuccess = true,
						Item = orderInfo
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<OrderService.OrderInfo>
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
		public IActionResult InsertOrder(OrderService.OrderInfo infoInsert)
		{
			try
			{
				using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
				{
					var result = OrderService.GetInstance().Insert(connection, infoInsert);

					if (result.HasValue)
					{
						infoInsert.OrderID = result.Value;
					}

					return Ok(new SingleResponseMessage<OrderService.OrderInfo>
					{
						IsSuccess = result.HasValue,
						Item = infoInsert
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<OrderService.OrderInfo>(ex.Message.ToString()));
			}
		}

        [HttpPut("{orderID}")]
        public IActionResult UpdateOrder(OrderService.OrderInfo infoUpdate)
        {
            try
            {
                using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
                {
                    bool result = OrderService.GetInstance().Update(connection, infoUpdate);

					return Ok(new SingleResponseMessage<OrderService.OrderInfo>
					{
						IsSuccess = result,
						Item = infoUpdate
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<OrderService.OrderInfo>(ex.Message.ToString()));
			}
		}

        [HttpDelete("{orderID}")]
        public IActionResult DeleteOrder(int orderID)
        {
            try
            {
                using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
                {
                    bool result = OrderService.GetInstance().Delete(connection, orderID);

					return Ok(new SingleResponseMessage<OrderService.OrderInfo>
					{
						IsSuccess = result
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<OrderService.OrderInfo>(ex.Message.ToString()));
			}
		}
	}
}
