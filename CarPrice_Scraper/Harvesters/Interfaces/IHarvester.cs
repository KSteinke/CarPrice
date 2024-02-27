namespace CarPrice_Scraper.Harvesters.Interfaces;

public interface IHarvester
{
    //TODO - Indicate datatype
    Task</*DATATYPE*/> HarvestData();
}