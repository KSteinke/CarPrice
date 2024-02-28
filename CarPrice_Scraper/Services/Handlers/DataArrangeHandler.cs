using System.ComponentModel.DataAnnotations;
using CarPrice_Scraper.Harvesters.Interfaces;

namespace CarPrice_Scraper.Harvesters;

public class DataArrangeHandler : IDataArrangeHandler
{
    private readonly IDataArranger _dataArranger;
    private readonly ICommunicationHandler _communicationHandler;

    public DataArrangeHandler(IDataArranger dataArranger, ICommunicationHandler communicationHandler)
    {
        _dataArranger = dataArranger;
        _communicationHandler = communicationHandler;
    }

    public async Task<DATATEST> HandleRawData( /* Add data type */ harvestResult)
    {
        try
        {
            var arrangedData = _dataArranger.ArrangeRawData(harvestResult);
            await _communicationHandler.HandleArrangedData(arrangedData);
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}