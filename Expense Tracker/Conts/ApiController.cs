using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Conts
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        public ActionResult Index()
        {
            return Ok(new string[] { "Hello", "Dattatray" });
        }

    }
}
