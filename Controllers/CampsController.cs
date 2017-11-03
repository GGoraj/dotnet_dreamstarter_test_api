using Microsoft.AspNetCore.Mvc;

namespace dreamstarter.Controllers{
    [Route("api/")]
    public class RootApiController : Controller{

        [HttpGet("")]
        public IActionResult ApiRootGet(){
            
            var response = new{
                href = "???"
            };
            /*Ok is a normal response code 200 */
            return Ok(response);
        }
    }
}