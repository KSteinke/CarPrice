using CarPrice_Models.Enums;

namespace CarPrice_DataAccess.Entities;
    public class Car
    {
        public Guid Id {get; set;}
        public string CarBrand {get; set;}
        public string Model {get; set;}
        int ProdStartYear {get; set;}
        int ProdEndYear {get; set;}
        public Engine Engine {get; set;}
        public List<Record> Records {get; set;}
    }