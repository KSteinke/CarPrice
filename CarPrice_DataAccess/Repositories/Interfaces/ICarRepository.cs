namespace CarPrice_DataAccess.Repositories.Interfaces
{
    public interface ICarRepository
    {
        Task<IEnumerable<string>> GetCarBrands();
        Task<IEnumerable<string>> GetCarModels(string carBrand);
    }

}