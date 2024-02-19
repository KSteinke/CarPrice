using CarPrice_Models.Enums;

namespace CarPrice_Models.Dtos;

public record SearchDataDto(string CarBrand, string Model, CarozzeriaEnum Carozzeria, MilageGroupEnum MilageGroup, FuelTypeEnum FuelType, string Volume, string Power, VoivoidshipEnum VoivoidshipName);
