using CarPrice_DataAccess.Entities;
using CarPrice_DataAccess.Extentions;
using CarPrice_DataAccess.Repositories.Interfaces;
using CarPrice_DataAccess.Services.Interfaces;
using CarPrice_Models.Dtos;
using CarPrice_Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CarPrice_DataAccess.Repositories;
    public class RecordRepository:IRecordRepository
    {
        private readonly CarPriceDbContext _carPriceDbContext;
        private readonly IGetRecordsQueryBuilderService _getRecordsQueryBuilderService;
        public RecordRepository(CarPriceDbContext carPriceDbContext, IGetRecordsQueryBuilderService getRecordsQueryBuilderService)
        {
            _carPriceDbContext = carPriceDbContext;
            _getRecordsQueryBuilderService = getRecordsQueryBuilderService;
        }

        public async Task<IEnumerable<GetRecordsDto>> GetRecords(SearchDataDto searchDataDto)
        {
            IQueryable<Record> query = _carPriceDbContext.Records;
            _getRecordsQueryBuilderService.BuildGetRecordsQuery(ref query, searchDataDto);

            if(query.IsNullOrEmpty())
            {
                return Enumerable.Empty<GetRecordsDto>();
            }

            IEnumerable<Record> records = await query.ToListAsync();
            if(records.IsNullOrEmpty())
            {
                return Enumerable.Empty<GetRecordsDto>();
            }

            IEnumerable<GetRecordsDto> getRecordsDtos = records.ConvertToGetRecordsDto();
            if(getRecordsDtos.IsNullOrEmpty())
            {
                return Enumerable.Empty<GetRecordsDto>();
            }
            
            return getRecordsDtos;
        }
    }
