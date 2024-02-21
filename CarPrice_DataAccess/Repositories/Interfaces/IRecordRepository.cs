using CarPrice_DataAccess.Entities;
using CarPrice_Models.Dtos;

namespace CarPrice_DataAccess.Repositories.Interfaces
{
    public interface IRecordRepository
    {
        Task<IEnumerable<GetRecordsDto>> SearchRecords(SearchDataDto searchDataDto);
        Task<Record> UploadRecord(UploadRecordDto uploadRecordDto);
    }
}