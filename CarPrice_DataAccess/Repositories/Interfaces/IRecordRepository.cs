using CarPrice_Models.Dtos;

namespace CarPrice_DataAccess.Repositories.Interfaces
{
    public interface IRecordRepository
    {
        Task<IEnumerable<GetRecordsDto>> GetRecords(SearchDataDto searchDataDto);
    }
}