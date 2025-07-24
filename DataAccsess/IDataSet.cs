using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess
{
    public interface IDataSet<T> where T : class
    {
        void Save(T Data);
        T GetById(int Id);
        List<T> GetAll();
    }
}
