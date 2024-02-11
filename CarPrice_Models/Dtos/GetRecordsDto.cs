namespace CarPrice_Models.Dtos;
using CarPrice_Models.Enums;
public class GetRecordsDto
{
    public Guid Id {get; set;}
    public DateTime Date {get; set;}
    public int AvgPrice {get; set;}
    public int MaxPrice {get; set;}
    public int MinPrice {get; set;}
    public int MedianPrice {get; set;}
    public int OffersNuber {get; set;}

}