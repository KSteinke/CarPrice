using CarPrice_Models.Enums;

namespace CarPrice_Models.Dtos;

public class SearchDataDto
{
    public string CarBrand {get; set;}
    public string Model {get; set;}
    public CarozzeriaEnum Carozzeria {get; set;}
    public MilageGroupEnum MilageGroup {get; set;}
    public FuelTypeEnum FuelType {get; set;}
    public int Volume {get; set;} 
    public int Power {get; set;}
}