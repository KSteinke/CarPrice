namespace CarPrice_Server.Entities
{
    public class Car
    {
        public int Id {get; set;}
        public string? CarBrand {get; set;}
        public string? Model {get; set;}
        public int ProdYear {get; set;}
        public string? Carozzeria {get; set;}
        public string? MilageGroup {get; set;}
        public Engine Engine {get; set;}
        public List<Record> Records {get; set;}
    }

}