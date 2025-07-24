using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal interface IPtServiceBus <T> where T : class
    {
        void AddPt(String name, String Lname, String TC, DateOnly dob, String gender, String ph, String adress, bool foreign);
        void AddPt(T data);
        T GetPtById(int id);
        List<T> GetAllPts();
    }
}
