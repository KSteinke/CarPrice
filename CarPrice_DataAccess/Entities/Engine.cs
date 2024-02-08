namespace CarPrice_Server.Entities
{
    public class Engine
    {
        public int Id {get; set;}
        public string? FuelType {get; set;}
        public int Volume {get; set;}
        public int Power {get; set;}
        public List<Car> Cars {get; set;}
    }
}