using Microsoft.AspNetCore.Mvc;

namespace IsdPersonalWebsiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class UIDataController : ControllerBase
    {
        private readonly ILogger<UIDataController> _logger;
        public UIDataController(ILogger<UIDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetUiData()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader("Data/data.json"))
                {
                    string json = streamReader.ReadToEnd();
                    return Ok(json);
                }
            }
            catch(Exception exception)
            {
                return BadRequest(exception.Message);
            }        
        }
    }
}