using CarPrice_Models.Enums;

namespace CarPrice_DataAccess.Entities;
    public class Engine
    {
        public Guid Id {get; set;}
        public FuelTypeEnum FuelType {get; set;}
        public int Volume {get; set;}           //Engine volume in cm3
        public int Power {get; set;}
        public List<Car> Cars {get; set;}
    }
