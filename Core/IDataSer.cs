using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IDataSer<T> where T : class
    {
        Task<List<T>> GetAllService();
        Task<T> GetByIdService(int Id);
        Task<List<T>> GetByNameService(string Name);
        Task<T> SaveService(T Data);
        Task DeleteService(int Id);
    }
}
