namespace CarPrice_DataAccess.Entities;
    public class Voivoidship
    {
        public Guid Id {get; set;}
        public string? Name {get; set;}
        public List<Record> Records {get; set;}
    }