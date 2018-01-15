using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CTMerge.API.Controllers
{
    public class AuthenticationController : ApiController
    {
        [Route("api/v1/UserAuthen/")]
        [HttpGet]
        public IHttpActionResult UserAuthen(string username,string password)
        {
            var result = new CTMerge.API.BusinessLogic.AuthenticationBL().Checkpassword(username, password);
            //var result = true;
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [Route("api/v1/UserResult/")]
        [HttpGet]
        public IHttpActionResult UserResult(string username, string password)
        {
            var result = new CTMerge.API.BusinessLogic.AuthenticationBL().GetUserResult(username, password);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}
