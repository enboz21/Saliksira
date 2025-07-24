using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess
{
    public interface IDataSet<T> where T : class
    {
        Task Save(T Data);
        Task<T> GetById(int Id);
        Task<List<T>> GetAll();
    }
}
