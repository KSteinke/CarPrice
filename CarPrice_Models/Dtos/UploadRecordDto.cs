namespace CarPrice_Models.Dtos;

public record UploadRecordDto(DateOnly Date, int AvgPrice, int MaxPrice, int MinPrice, int MedianPrice, int OffersNuber, Guid CarId);
