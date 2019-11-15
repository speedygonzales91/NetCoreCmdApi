using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CmdApi.Controllers
{
    [Route("api/command")]
    [ApiController]
    public class CommandController : ControllerBase 
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] {"this","is","hardcoded"};
        }
    }
}