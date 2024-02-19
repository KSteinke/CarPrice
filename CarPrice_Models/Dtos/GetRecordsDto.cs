namespace CarPrice_Models.Dtos;
using CarPrice_Models.Enums;
public record GetRecordsDto(Guid Id, DateTime Date, int AvgPrice, int MaxPrice, int MinPrice, int MedianPrice, int OffersNuber);
