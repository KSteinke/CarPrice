using CarPrice_DataAccess.Entities;
using CarPrice_DataAccess.Services.Interfaces;
using CarPrice_Models.Dtos;

namespace CarPrice_DataAccess.Services;

public class GetRecordsQueryBuilderService : IGetRecordsQueryBuilderService
{
    public IQueryable<Record> BuildGetRecordsQuery(ref IQueryable<Record> query, SearchDataDto searchDataDto)
    {
        query.Where(r => r.Car.Model == searchDataDto.Model);

        if(searchDataDto.Carozzeria != CarPrice_Models.Enums.CarozzeriaEnum.All)
        {
            query.Where(r => r.Car.Carozzeria == searchDataDto.Carozzeria);
        }

        if(searchDataDto.MilageGroup != CarPrice_Models.Enums.MilageGroupEnum.All)
        {
            query.Where(r => r.Car.MilageGroup == searchDataDto.MilageGroup);
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

        if(searchDataDto.Power != "All")
        {
            int power;
            if(int.TryParse(searchDataDto.Power, out power))
            {
                query.Where(r => r.Car.Engine.Power == power);
            }
            else
            {
                return null;
            }
        }

        if(searchDataDto.VoivoidshipName != CarPrice_Models.Enums.VoivoidshipEnum.All)
        {
            query.Where(r => r.Voivoidship.Name == searchDataDto.VoivoidshipName);
        }

        return query;
    }
}