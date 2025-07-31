namespace Core
{
    public interface IDataSet<T> where T : class
    {
        Task Delete(int Id);

        Task<List<T>> GetAll();
        Task<T> GetById(int Id);

        Task<List<T>> GetByName(string Name);

        Task<T> Save(T Data);

        Task<List<T>> GetByTc(String Tc);
    }
}
