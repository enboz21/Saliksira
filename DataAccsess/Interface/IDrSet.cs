using Core;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Interface
{
    public interface IDrSet : IDataSet<Doktorlar>
    {
        Task<List<Doktorlar>> GetByName(string Name);
        Task<List<Doktorlar>> GetByVa();
    }
}
