using CarPrice_DataAccess.Entities;
using CarPrice_DataAccess.Services.Interfaces;
using CarPrice_Models.Dtos;

namespace CarPrice_DataAccess.Services;

public class GetRecordsQueryBuilderService : IGetRecordsQueryBuilderService
{
    public IQueryable<Record> BuildGetRecordsQuery(ref IQueryable<Record> query, SearchDataDto searchDataDto)
    {
        query.Where(r=> r.Car.CarBrand == searchDataDto.CarBrand);

        query.Where(r => r.Car.Model == searchDataDto.Model);

        query.Where(r => r.CarProdYear == searchDataDto.ProdYear);

        if(searchDataDto.MilageGroup != CarPrice_Models.Enums.MilageGroupEnum.All)
        {
            query.Where(r => r.MilageGroup == searchDataDto.MilageGroup);
        }

        if(searchDataDto.FuelType != CarPrice_Models.Enums.FuelTypeEnum.All)
        {
            query.Where(r => r.Car.Engine.FuelType == searchDataDto.FuelType);
        }

        if(searchDataDto.Volume != "All")
        {
            int volume;
            if(int.TryParse(searchDataDto.Volume, out volume))
            {
                query.Where(r => r.Car.Engine.Volume == volume);
            }
            else
            {
                return null;
            }
        }

        if(searchDataDto.VoivoidshipName != CarPrice_Models.Enums.VoivoidshipEnum.All)
        {
            query.Where(r => r.Voivoidship == searchDataDto.VoivoidshipName);
        }

        return query;
    }
}