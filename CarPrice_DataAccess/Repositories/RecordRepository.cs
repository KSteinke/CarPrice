using CarPrice_DataAccess.Entities;
using CarPrice_DataAccess.Extentions;
using CarPrice_DataAccess.Repositories.Interfaces;
using CarPrice_DataAccess.Services.Interfaces;
using CarPrice_Models.Dtos;
using CarPrice_Server.Data;
using Microsoft.AspNetCore.Mvc;
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

        public async Task UploadRecord([FromBody] UploadRecordDto uploadRecordDto)
        {
            var car = await _carPriceDbContext.Cars.Where(c => c.Id == uploadRecordDto.CarId).FirstOrDefaultAsync();
            if(car == null)
            {
                //TODO - Add wrong task
            }

            var record = uploadRecordDto.ConvertFromDto(car); //TODO conver from DTO voivoidship Update
            var result = await _carPriceDbContext.Records.AddAsync(record);
            await _carPriceDbContext.SaveChangesAsync();
        }

    }
