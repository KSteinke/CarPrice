using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ScraperController : ControllerBase
{
    private readonly IHostedService _scraperService;

    public ScraperController(IHostedService scraperService)
    {
        _scraperService = scraperService;
    }

    [HttpPost("start")]
    public IActionResult StartScraperService()
    {
        if (_scraperService is ScraperService scraperService)
        {
            scraperService.StartAsync(default).Wait(); 
            return Ok("Background service started.");
        }
        else
        {
            return BadRequest("Background service not found.");
        }
    }
}