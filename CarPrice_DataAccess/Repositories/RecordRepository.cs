using System.Net;
using CarPrice_DataAccess.Entities;
using CarPrice_DataAccess.Extentions;
using CarPrice_DataAccess.Repositories.Interfaces;
using CarPrice_DataAccess.Services.Interfaces;
using CarPrice_Models.Dtos;
using CarPrice_Server.Data;
using Microsoft.AspNetCore.Http.HttpResults;
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

        public async Task<IEnumerable<GetRecordsDto>> SearchRecords(SearchDataDto searchDataDto)
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

        public async Task<Record> UploadRecord(UploadRecordDto uploadRecordDto)
        {
            try
            {
                var car = await _carPriceDbContext.Cars.Where(c => c.Id == uploadRecordDto.CarId).FirstOrDefaultAsync() ?? throw new InvalidOperationException("No car with this Id.");
                var record = uploadRecordDto.ConvertFromDto(car);
                var result = await _carPriceDbContext.Records.AddAsync(record);

                if (await _carPriceDbContext.SaveChangesAsync() > 0)
                {
                    return record;
                }
                else
                {
                    throw new InvalidOperationException("Error during record save");
                }
                }
                catch (Exception ex)
                {
                    return null;
                }
        }
    }
