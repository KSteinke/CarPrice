using CarPrice_Models.Enums;

namespace CarPrice_Models.Dtos;

public record UploadRecordDto(DateOnly Date, int AvgPrice, int MaxPrice, int MinPrice, int MedianPrice, MilageGroupEnum MilageGroup, int OffersNuber, int CarProdYear, Guid CarId, VoivoidshipEnum Voivoidship);
