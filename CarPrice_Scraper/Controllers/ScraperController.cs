
using CarPrice_Scraper.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ScraperController : ControllerBase
{
    private readonly IScraperService _scraperService;

    public ScraperController(IScraperService scraperService)
    {
        _scraperService = scraperService;
    }
    
    [HttpGet]
    [Route("status")]
    public async Task<ActionResult<bool>> GetStatus()
    {
        return Ok(await _scraperService.IsRunning());
    }

    [HttpPost]
    [Route("start")]
    public async Task<ActionResult> StartService()
    {
        await _scraperService.Start();
        return Ok();
    }

    [HttpPost]
    [Route("stop")]
    public async Task<ActionResult> StopService()
    {
        await _scraperService.Stop();
        return Ok();
    }
    
}