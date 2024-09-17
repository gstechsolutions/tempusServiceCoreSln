using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using tempus.service.core.api.Models.POSTempus;
using tempus.service.core.api.Services.POSTempus;

namespace tempus.service.core.api.Controllers
{
    [ApiController]
    public class TempusController : ControllerBase
    {
        private readonly ITempusService service;

        public TempusController(ITempusService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("api/tempus/saleauth")]
        [SwaggerOperation(OperationId = "PaymentTempusMethods_Select")]
        [SwaggerResponse(statusCode: 200, type: typeof(PaymentTempusMethodRequest), description: "Used to call Tempus for auth sale")]
        public async Task<IActionResult> PaymentTempusMethods_Select([FromBody] PaymentTempusMethodRequest order)
        {
            var response = await service.PaymentTempusMethods_Select(order);
            return Ok(response);
        }

        [HttpGet]
        [Route("api/tempus/location/list")]
        [SwaggerOperation(OperationId = "GetLocations")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<LocationModel>), description: "Used to retrieve list of locations.")]
        public async Task<IActionResult> GetLocations()
        {
            var list = await service.GetLocations();
            return Ok(list);
        }
    }
}
