using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrashanthQuickComAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("GetAllCategories")]

        public void GetAllCategories()
        {


        }
    }
}
