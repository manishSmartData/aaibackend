using AAI.RepositoryContract.Login;
using AAI.ServiceContract.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AAI.Web.API.Controllers
{
    [Route("api/[controller]")]
    public class CommonController : ControllerBase
    {
        protected readonly ICommonService _commonService;

        public CommonController(ICommonService commonService)
        {
            _commonService = commonService;
        }

        [HttpGet]
        [Route("getPublicAct")]
        public async Task<IActionResult> GetPublicAct()
        {
            IActionResult response = null; 
            var measureList = await _commonService.GetPublicActListAsync();
            response = Ok(measureList); 
            return response;
        }
    }
}
