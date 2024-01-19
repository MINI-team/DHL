using Application.Orders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : BaseApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public string test(int id)
        {
            return "Works fine";
        }
    }
}