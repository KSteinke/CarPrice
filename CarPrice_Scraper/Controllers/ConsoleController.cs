
using CarPrice_Scraper.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ConsoleController : ControllerBase
{
    private readonly IConsoleService _consoleService;

    public ConsoleController(IConsoleService consoleService)
    {
        this._consoleService = consoleService;
    }

    [HttpGet]
    [Route("status")]
    public ActionResult<bool> GetStatus()
    {
        return Ok(_consoleService.IsRunning);
    }

    [HttpPost]
    [Route("start")]
    public ActionResult StartService()
    {
        _consoleService.Start();
        return Ok();
    }

    [HttpPost]
    [Route("stop")]
    public ActionResult StopService()
    {
        _consoleService.Stop();
        return Ok();
    }
}