namespace CarPrice_DataAccess.Entities;
    public class Car
    {
        public Guid Id {get; set;}
        public string CarBrand {get; set;}
        public string Model {get; set;}
        public int ProdYear {get; set;}
        public string Carozzeria {get; set;}
        public string MilageGroup {get; set;}
        public Engine Engine {get; set;}
        public List<Record> Records {get; set;}
    }