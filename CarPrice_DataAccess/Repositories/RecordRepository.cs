using CarPrice_DataAccess.Entities;
using CarPrice_DataAccess.Repositories.Interfaces;

namespace CarPrice_DataAccess.Repositories;
    public class RecordRepository:IRecordRepository
    {
        public async Task<IEnumerable<Record>> GetRecords()
        {
            
        }
    }
