using Core;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Interface
{
    public interface IPtSet : IDataSet<Hastalar>
    {
        Task<Hastalar> GetByTc(String Tc);
        Task<List<Hastalar>> GetAll();
        Task<List<Hastalar>> GetByName(string Name);
    }
}
