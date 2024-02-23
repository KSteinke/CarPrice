using CarPrice_DataAccess.Entities;
using CarPrice_Models.Dtos;

namespace CarPrice_DataAccess.Extentions;

public static class DtoConvertions
{
    public static IEnumerable<GetRecordsDto> ConvertToGetRecordsDto(this IEnumerable<Record> records)
    {

        IEnumerable<GetRecordsDto> getRecordsDto = (from record in records
                                                    select new GetRecordsDto(default, default, default, default, default, default, default, default, default)
                                                    {
                                                        Id = record.Id,
                                                        Date = record.Date,
                                                        AvgPrice = record.AvgPrice,
                                                        MaxPrice = record.MaxPrice,
                                                        MinPrice = record.MinPrice,
                                                        MedianPrice = record.MedianPrice,
                                                        CarProdYear = record.CarProdYear,
                                                        MilageGroup = record.MilageGroup,
                                                        OffersNuber = record.OffersNuber
                                                    });
        return getRecordsDto;
    }


    public static Record ConvertFromDto(this UploadRecordDto uploadRecordDto, Car car)
    {
        Record record = new()
        {
            Date = uploadRecordDto.Date,
            AvgPrice = uploadRecordDto.AvgPrice,
            MaxPrice = uploadRecordDto.MaxPrice,
            MinPrice = uploadRecordDto.MinPrice,
            MedianPrice = uploadRecordDto.MedianPrice,
            MilageGroup = uploadRecordDto.MilageGroup,
            CarProdYear = uploadRecordDto.CarProdYear,
            OffersNuber = uploadRecordDto.OffersNuber,
            Car = car,
            Voivoidship = uploadRecordDto.Voivoidship
        };

        return record;
    }
}