namespace CarPrice_DataAccess.Repositories.Interfaces
{
    public interface ICarRepository
    {
        Task<IEnumerable<string>> GetCarBrands();
    }
}