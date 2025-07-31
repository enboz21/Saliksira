using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface testCore<T, TT> where T : class where TT : class
    {
        Task<List<TT>> GetAllService();
        Task<T> GetByIdService(int Id);
        Task<List<T>> GetByNameService(string Name);
        Task<TT> SaveService(TT Data);
        Task DeleteService(int Id);
        Task<List<TT>> GetByTcService(String Tc);
    }
}
