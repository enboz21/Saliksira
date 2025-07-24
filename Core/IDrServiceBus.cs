
namespace Business
{
    public interface IDrServiceBus <T> where T : class
    {
        void AddDoctor(string name, string Lname, string expertise, string ph, bool active);
        void AddDoctor(T data);
        Task<T> GetDoctorById(int id);
        Task<List<T>> GetAllDoctors();
    }
}
