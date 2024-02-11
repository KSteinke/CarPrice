using CarPrice_DataAccess.Entities;
using CarPrice_DataAccess.Repositories.Interfaces;
using CarPrice_Models.Dtos;
using CarPrice_Server.Data;

namespace CarPrice_DataAccess.Repositories;
    public class RecordRepository:IRecordRepository
    {
        private readonly CarPriceDbContext _carPriceDbContext;
        public RecordRepository(CarPriceDbContext carPriceDbContext)
        {
            _carPriceDbContext = carPriceDbContext;
        }

        public async Task<IEnumerable<GetRecordsDto>> GetRecords(SearchDataDto searchDataDto)
        {
            IQueryable<Record> query = _carPriceDbContext.Records.Where(c=>c.Car.)
        }
    }
