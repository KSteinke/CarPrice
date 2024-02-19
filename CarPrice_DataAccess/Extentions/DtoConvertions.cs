using CarPrice_DataAccess.Entities;
using CarPrice_Models.Dtos;

namespace CarPrice_DataAccess.Extentions;

public static class DtoConvertions
{
    public static IEnumerable<GetRecordsDto> ConvertToGetRecordsDto(this IEnumerable<Record> records)
    {

        IEnumerable<GetRecordsDto> getRecordsDto = (from record in records
                                                    select new GetRecordsDto(default, default, default, default, default, default, default)
                                                    {
                                                        Id = record.Id,
                                                        Date = record.Date,
                                                        AvgPrice = record.AvgPrice,
                                                        MaxPrice = record.MaxPrice,
                                                        MinPrice = record.MinPrice,
                                                        MedianPrice = record.MedianPrice,
                                                        OffersNuber = record.OffersNuber
                                                    });
        return getRecordsDto;
    }
}