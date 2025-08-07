namespace Core
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIdService(int Id);
        Task DeleteService(int Id);
    }
}
