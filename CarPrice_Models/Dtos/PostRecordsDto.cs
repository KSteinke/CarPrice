namespace CarPrice_Models.Dtos;
using CarPrice_Models.Enums;
public record PostRecordsDto(Guid Id, DateOnly Date, int AvgPrice, int MaxPrice, int MinPrice, int MedianPrice, int OffersNuber);
