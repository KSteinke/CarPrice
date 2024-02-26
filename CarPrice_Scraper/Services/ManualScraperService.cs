using CarPrice_Scraper.Services.Interfaces;

/// <summary>
/// Scraper service 
/// </summary>
public class ManualScraperService : IScraperService
{
    private readonly IHarvestHandler _harvestHandler;
    private bool _isRunningValue;

    public bool IsRunningValue
    {
        get {return _isRunningValue;}
        set{_isRunningValue = value;}
    }

    public ManualScraperService(IHarvestHandler harvestHandler)
    {
        _harvestHandler = harvestHandler;
        _isRunningValue = false;
    }

    
    public async Task Start()
    {
        try
        {
            //TODO - implement HarvestHandler
            //_harvestHandler.StartHarvesting();
        }
        catch (Exception)
        {
            throw new Exception("Error in during scraper start.");
        }
    }

    public async Task Stop()
    {
        //TODO - implement STOP functionality
    }

    public async Task<bool> IsRunning()
    {
       return await Task.FromResult(_isRunningValue);
    }

}