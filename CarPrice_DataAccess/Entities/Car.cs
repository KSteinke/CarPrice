using CarPrice_DataAccess.Enums;

namespace CarPrice_DataAccess.Entities;
    public class Car
    {
        public Guid Id {get; set;}
        public string CarBrand {get; set;}
        public string Model {get; set;}
        public int ProdYear {get; set;}
        public CarozzeriaEnum Carozzeria {get; set;}
        public MilageGroupEnum MilageGroup {get; set;}
        public Engine Engine {get; set;}
        public List<Record> Records {get; set;}
    }