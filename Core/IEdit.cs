using System;
using System.Linq;

namespace Core
{
    public interface IEdit<T> where T : class
    
    {
        Task<List<T>> GetAllAp();
    }
}
