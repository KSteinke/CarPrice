using CarPrice_DataAccess.Entities;
using CarPrice_Models.Dtos;

namespace CarPrice_DataAccess.Services.Interfaces;

public interface IGetRecordsQueryBuilderService
{
    IQueryable<Record> BuildGetRecordsQuery(ref IQueryable<Record> query, SearchDataDto searchDataDto);
}