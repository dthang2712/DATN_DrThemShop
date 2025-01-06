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
    public class OrderDetailController : Controller
    {
        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [HttpGet("{orderID}")]
        public IActionResult SearchOrderDetail(int orderID)
        {
            try
            {
                using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
                {
                    List<OrderDetailService.OrderDetailInfo> listOrderDetailInfo = OrderDetailService.GetInstance().GetListOrderDetail(connection, orderID);

					return Ok(new ListResponseMessage<OrderDetailService.OrderDetailInfo>
					{
						IsSuccess = true,
						TotalRecords = listOrderDetailInfo.Count,
						Data = listOrderDetailInfo
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new ListResponseMessage<OrderDetailService.OrderDetailInfo>
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
        public IActionResult InsertOrderDetail(OrderDetailService.OrderDetailInfo infoInsert)
        {
            try
            {
                using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
                {
                    bool result = OrderDetailService.GetInstance().Insert(connection, infoInsert);

					return Ok(new SingleResponseMessage<OrderDetailService.OrderDetailInfo>
					{
						IsSuccess = result,
						Item = infoInsert
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<OrderDetailService.OrderDetailInfo>(ex.Message.ToString()));
			}
		}

        [HttpPut("{orderDetailID}")]
        public IActionResult UpdateOrderDetail(OrderDetailService.OrderDetailInfo infoUpdate)
        {
            try
            {
                using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
                {
                    bool result = OrderDetailService.GetInstance().Update(connection, infoUpdate);

					return Ok(new SingleResponseMessage<OrderDetailService.OrderDetailInfo>
					{
						IsSuccess = result,
						Item = infoUpdate
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<OrderDetailService.OrderDetailInfo>(ex.Message.ToString()));
			}
		}

        [HttpDelete("{orderDetailID}")]
        public IActionResult DeleteOrderDetail(int orderDetailID)
        {
            try
            {
                using (var connection = DefaultConnectionFactory.DRThem.GetConnection())
                {
                    bool result = OrderDetailService.GetInstance().Delete(connection, orderDetailID);

					return Ok(new SingleResponseMessage<OrderDetailService.OrderDetailInfo>
					{
						IsSuccess = result
					});
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return Ok(new SingleResponseMessage<OrderDetailService.OrderDetailInfo>(ex.Message.ToString()));
			}
		}
	}
}
