namespace CarPrice_DataAccess.Entities;
    public class Record
    {
        public Guid Id {get; set;}
        public DateTime Date {get; set;}
        public int AvgPrice {get; set;}
        public int MaxPrice {get; set;}
        public int MinPrice {get; set;}
        public int MedianPrice {get; set;}
        public int OffersNuber {get; set;}
        public Car? Car {get; set;}
        public Voivoidship Voivoidship {get; set;}
    }
