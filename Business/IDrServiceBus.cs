
using Entity;

namespace Business
{
    public interface IDrServiceBus <T> where T : class
    {
        void AddDoctor(string name, string Lname, string expertise, string ph, bool active);
        void AddDoctor(T data);
        T GetDoctorById(int id);
        List<T> GetAllDoctors();
    }
}
