namespace CarPrice_Models.Dtos;

public class UploadRecordDto
{
    public DateOnly Date {get; set;}
    public int AvgPrice {get; set;}
    public int MaxPrice {get; set;}
    public int MinPrice {get; set;}
    public int MedianPrice {get; set;}
    public int OffersNuber {get; set;}

    
}