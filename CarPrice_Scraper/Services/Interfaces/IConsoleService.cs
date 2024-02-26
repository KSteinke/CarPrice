namespace CarPrice_Scraper.Services.Interfaces;
public interface IConsoleService
{
    void Start();
    void Stop();
    bool IsRunning { get; }
}