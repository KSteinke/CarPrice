using CarPrice_Models.Enums;

namespace CarPrice_Models.Dtos;

public class SearchDataDto
{
    public string CarBrand {get; set;}
    public string Model {get; set;}
    public CarozzeriaEnum Carozzeria {get; set;}
    public MilageGroupEnum MilageGroup {get; set;}
    public FuelTypeEnum FuelType {get; set;}
    public string Volume {get; set;}
    public string Power {get; set;}
    public VoivoidshipEnum VoivoidshipName {get; set;}
}