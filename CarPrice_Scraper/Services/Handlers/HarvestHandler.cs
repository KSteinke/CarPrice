public class HarvestHandler : IHarvestHandler
{
    private readonly IHarvester _harvester;
    private readonly IDataArrangeHandler _dataArrangeHandler;
    public HarvestHandler(IHarvester harvester, IDataArrangeHandler _dataArrangeHandler)
    {
        _harvester = harvester;
        _dataArrangeHandler = dataArrangeHandler;
    }

    //TO DO - add return type
    /// <summary>
    /// Method responsible for harvester invoque and passing data to IDataSelectorHandler
    /// </summary>
    /// <returns></returns>
    public async Task HandleHarvesting()
    {
        try
        {
            var harvestResult = await _harvester.HarvestData();
            await _dataSelectorHandler.HandleRawData(harvestResult);
        }
        catch(Exception ex)
        {
            throw new Exception("Error in Harvest Handling.");
        }

    }
}