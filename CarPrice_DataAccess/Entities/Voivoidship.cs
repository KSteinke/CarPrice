using CarPrice_DataAccess.Enums;

namespace CarPrice_DataAccess.Entities;
    public class Voivoidship
    {
        public Guid Id {get; set;}
        public VoivoidshipEnum Name {get; set;}
        public List<Record> Records {get; set;}
    }