namespace CarPrice_Scraper.Services.Interfaces;
public interface IScraperService
{
    Task Start();
    Task Stop();
    Task<bool> IsRunning();
}