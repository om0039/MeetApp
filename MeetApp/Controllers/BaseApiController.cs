using MeetApp.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace MeetApp.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {

    }
}