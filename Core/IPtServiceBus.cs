using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IPtServiceBus <T> where T : class
    {
        void AddPt(String name, String Lname, String TC, DateOnly dob, String gender, String ph, String adress);
        void AddPt(T data);
        Task<T> GetPtById(int id);
        Task<List<T>> GetAllPts();
    }
}
