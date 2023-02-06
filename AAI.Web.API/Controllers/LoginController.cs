using AAI.DataContract.Common;
using AAI.DataContract.Models.Entity.DB;
using AAI.DataContract.Models.Login;
using AAI.RepositoryContract.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace AAI.Web.API.Controllers
{
    [Route("api/[controller]")]
  
    public class LoginController : ControllerBase
    {
       
        protected readonly ILoginInterface _loginInterface;
        //private readonly EntityDbContext _entitycontext;

        public LoginController(ILoginInterface loginInterface)
        {
            _loginInterface = loginInterface;
            //_entitycontext = entitycontext;
        }

        [HttpPost]
        [Route("loginDetail")]
        public async Task<IActionResult> LoginDetail(LoginInputApiModel model)
        {
            ResponseStatus<dynamic> response = new ResponseStatus<dynamic>();
            try
            {
             //var result = await _entitycontext.User1.Where(a => a.Name == model.UserName).FirstOrDefaultAsync();
             var result = await _loginInterface.GetLoginDetailsAsync(model.email,model.Password);
                if (result != null)
                {
                   // response.Data = result;
                    response.StatusCode = HttpStatusCode.OK;
                    return Ok(response);
                }
                else
                {
                    response.Messages = "Error"; //CommonErrorMessages.CommonError;
                    response.StatusCode = HttpStatusCode.NoContent;
                    return NoContent();
                }

            }
            catch (Exception ex)
            {

            }
            return Ok();
        }


        

    }
}
