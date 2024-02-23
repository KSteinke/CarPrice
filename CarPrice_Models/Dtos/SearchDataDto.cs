using CarPrice_Models.Enums;

namespace CarPrice_Models.Dtos;

public record SearchDataDto(string CarBrand, string Model,int ProdYear, MilageGroupEnum MilageGroup, FuelTypeEnum FuelType, string Volume, VoivoidshipEnum VoivoidshipName);
